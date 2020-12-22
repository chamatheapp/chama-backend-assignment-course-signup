using System;
using System.Linq;
using CourseSignUp.Contracts.Events;
using CoursesSignUp.Core.DomainExceptions;
using CoursesSignUp.Core.Entities;
using CoursesSignUp.Core.ValueObjects;
using NUnit.Framework;

namespace CourseSignUp.Tests.Entities
{
    [TestFixture]
    public class CourseEntityTests
    {
        [SetUp]
        public void SetUp()
        {
            
        }

        [Test(Description = "Asserts a student can be enrolled")]
        public void GivenANewStudentIsTryingToEnroll_ShouldEnrollStudent()
        {
            var studentToEnroll = Student.From("Carl", "carl@chama.com", DateTime.UtcNow);
            
            Course course = Course.Factory("Course", 100);
            course.Enroll(studentToEnroll);

            Assert.Contains(studentToEnroll, course.EnrolledStudents);
        }
        
        [Test(Description = "Asserts that after a student is enrolled, side effects are published")]
        public void GivenANewStudentIsTryingToEnroll_ShouldEnrollStudentAndProduceSideEffects()
        {
            var studentToEnroll = Student.From("Carl", "carl@chama.com", DateTime.UtcNow);
            
            Course course = Course.Factory("Course", 100);
            course.Enroll(studentToEnroll);

            var @event = course.UncommittedEvents.FirstOrDefault(c => c is StudentEnrolledEvent) as StudentEnrolledEvent;
            Assert.NotNull(@event);
            Assert.NotNull(@event.Email);
            //TODO: Add the rest here??
        }
        
        [Test(Description = "Asserts a student cannot be enrolled more than once")]
        public void GivenAnExistingStudentIsTryingToEnroll_ShouldThrowException()
        {
            Student enrolledStudent = Student.From("Carl", "carl@chama.com", DateTime.UtcNow);
            
            Course course = Course.Factory("Course", 100);
            course.Enroll(enrolledStudent);
            
            Assert.Throws<StudentAlreadyEnrolledException>(() => course.Enroll(enrolledStudent));
        }
    }
}
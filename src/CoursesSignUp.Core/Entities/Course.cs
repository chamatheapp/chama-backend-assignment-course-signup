using System;
using System.Collections;
using System.Collections.Generic;
using Chama.Domain;
using CourseSignUp.Contracts.Events;
using CoursesSignUp.Core.DomainExceptions;
using CoursesSignUp.Core.ValueObjects;

namespace CoursesSignUp.Core.Entities
{
    public class Course : Entity
    {
        private Course()
        {
        }
        
        public string Id { get; private set; }
        public string Name { get; private set; }
        public int Capacity { get; private set; }
        public List<Student> EnrolledStudents { get; private set; } = new List<Student>();

        public static Course Factory(string name, int capacity)
        {
            return new Course
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                Capacity = capacity
            };
        }

        /// <summary>
        /// TODO: Here you are supposed to show your DDD & Distributed Services Skills
        /// 1) How do you ensure the course capacity was not exceeded?
        /// 1.1) Extra point if you add Optimistic Concurrency to the Entity
        /// 2) How do you enroll the student?
        /// 2.1) Is the Student already Enrolled? (TIP:"use StudentAlreadyEnrolledException)
        /// 3) Notify to Statistics that a new student has been enrolled?
        /// </summary>
        /// <param name="student"></param>
        /// <exception cref="MaximumCapacityExceededException"></exception>
        public void Enroll(Student student)
        {
            throw new NotImplementedException();

            // EnrolledStudents.Add(student);

            // throw new MaximumCapacityExceededException("Unable to enroll student", Capacity);

            // RaiseEvent(new StudentEnrolledEvent()
            // {
            //     Email = student.Email
            // });
        }
    }
}
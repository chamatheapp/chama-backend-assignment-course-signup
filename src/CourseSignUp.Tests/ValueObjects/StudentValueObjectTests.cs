using System;
using CoursesSignUp.Core.DomainExceptions;
using CoursesSignUp.Core.ValueObjects;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
using NUnit;
using NUnit.Framework;

namespace CourseSignUp.Tests.ValueObjects
{
    [TestFixture]
    public class StudentValueObjectTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test(Description = "Asserts that a Student can be created correctly")]
        public void GivenValidModel_ShouldProvideCorrectValueObject()
        {
            Student student = Student.From(
                "Carl",
                "carl@chama.com.br",
                new DateTime(1990, 6, 1)
            );

            Assert.IsNotNull(student);
            Assert.IsNotNull(student.Email);
            Assert.IsNotNull(student.Name);
            Assert.IsNotNull(student.DateOfBirth);
        }

        [Test(Description = "Asserts that a Student has a Valid Email")]
        public void GivenInvalidEmail_ShouldThrowException()
        {
            Assert.Throws<StudentEmailInvalidException>(() => Student.From(
                "Carl",
                "carl at chama.com.br",
                new DateTime(1990, 6, 1)
            ));
        }

        [Test(Description = "Asserts that a Student has a Valid Name")]
        public void GivenInvalidName_ShouldThrowException()
        {
            Assert.Throws<StudentNameInvalidException>(() => Student.From(
                null,
                "carl@chama.com.br",
                new DateTime(1990, 6, 1)
            ));
        }
    }
}
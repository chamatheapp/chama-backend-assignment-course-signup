using System;
using System.Collections.Generic;
using Chama.Domain;
using CoursesSignUp.Core.DomainExceptions;

namespace CoursesSignUp.Core.ValueObjects
{
    public class Student : ValueObject
    {
        private Student()
        {
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// TODO: Show your DDD skills here
        /// 1) Validate to assert the Student has the correct fields
        /// 1.1) Name has something in it?
        /// 1.2) Email is valid?
        /// 1.3) Is DateOfBirth after today?
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="dateOfBirth"></param>
        /// <returns></returns>
        public static Student From(string name, string email, DateTime dateOfBirth)
        {
            return new Student();
            // throw new StudentEmailInvalidException("", email);
            // throw new StudentNameInvalidException("", name);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
            yield return Email;
            yield return DateOfBirth;
        }
    }
}
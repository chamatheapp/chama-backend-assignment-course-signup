using System;

namespace CoursesSignUp.Core.DomainExceptions
{
    [Serializable]
    public class StudentAlreadyEnrolledException : Exception
    {
        public string Email { get; }

        public StudentAlreadyEnrolledException(string description, string email)
            : base(description)
        {
            Email = email;
        }
    }
}
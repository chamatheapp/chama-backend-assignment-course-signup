using System;

namespace CoursesSignUp.Core.DomainExceptions
{
    [Serializable]
    public class StudentEmailInvalidException : Exception
    {
        public string Value { get; }

        public StudentEmailInvalidException(string description, string value) : base(description)
        {
            Value = value;
        }
    }
}
using System;

namespace CoursesSignUp.Core.DomainExceptions
{
    [Serializable]
    public class StudentNameInvalidException : Exception
    {
        public string Value { get; }

        public StudentNameInvalidException(string description, string value) : base(description)
        {
            Value = value;
        }
    }
}
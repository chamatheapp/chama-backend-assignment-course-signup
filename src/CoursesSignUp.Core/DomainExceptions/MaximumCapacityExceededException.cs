using System;

namespace CoursesSignUp.Core.DomainExceptions
{
    [Serializable]
    public class MaximumCapacityExceededException : Exception
    {
        public int MaximumCapacityAllowed { get; private set; }

        public MaximumCapacityExceededException(string message, int maximumCapacityAllowed)
            : base(message)
        {
            MaximumCapacityAllowed = maximumCapacityAllowed;
        }
    }
}
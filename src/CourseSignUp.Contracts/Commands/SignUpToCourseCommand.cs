using System;
using Chama.Infrastructure.Messaging.Interfaces;

namespace CourseSignUp.Contracts.Commands
{
    public class SignUpToCourseCommand : ICommand
    {
        public string CourseId { get; set; }
        public StudentDto Student { get; set; }

        public class StudentDto
        {
            public string Email { get; set; }
            public string Name { get; set; }
            public DateTime Birthdate { get; set; }
        }
    }
}
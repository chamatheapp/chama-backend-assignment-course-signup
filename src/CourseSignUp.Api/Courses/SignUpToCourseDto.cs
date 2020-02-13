using System;

namespace CourseSignUp.Api.Courses
{
    public class SignUpToCourseDto
    {
        public string CourseId { get; set; }
        public StudentDto Student { get; set; }

        public class StudentDto
        {
            public string Email { get; set; }
            public string Name { get; set; }
            public DateTime DateOfBirth { get; set; }
        }
    }
}
namespace CourseSignUp.Api.Courses
{
    public class CreateCourseDto
    {
        public string LecturerId { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
    }
}
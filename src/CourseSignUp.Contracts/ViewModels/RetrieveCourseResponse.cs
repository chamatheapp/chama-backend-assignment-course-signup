using Chama.Infrastructure.Messaging.Interfaces;

namespace CourseSignUp.Contracts.ViewModels
{
    public class RetrieveCourseResponse : IOperationResponse
    {
        public string Id { get; set; }
        public int Capacity { get; set; }
        public int NumberOfStudents { get; set; }
    }
}
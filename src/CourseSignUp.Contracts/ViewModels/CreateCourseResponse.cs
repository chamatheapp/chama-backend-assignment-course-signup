using Chama.Infrastructure.Messaging.Interfaces;

namespace CourseSignUp.Contracts.ViewModels
{
    public class CreateCourseResponse : IOperationResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
    }
}
using Chama.Infrastructure.Messaging.Interfaces;

namespace CourseSignUp.Contracts.Requests
{
    public class CreateCourseRequest : IOperationRequest
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
    }
}
using Chama.Infrastructure.Messaging.Interfaces;

namespace CourseSignUp.Contracts.Requests
{
    public class RetrieveCourseRequest : IOperationRequest
    {
        public string Id { get; set; }
    }
}
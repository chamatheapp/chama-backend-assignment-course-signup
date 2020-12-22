using Chama.Infrastructure.Messaging.Interfaces;

namespace CourseSignUp.Contracts.ViewModels
{
    public class SignUpToCourseResponse : IOperationResponse
    {
        public bool Succeeded { get; set; }
    }
}
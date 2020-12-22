using Chama.Infrastructure.Messaging.Interfaces;

namespace CourseSignUp.Contracts.Events
{
    public class StudentEnrolledEvent : IEvent
    {
        public string Email { get; set; }
        //TODO: Dont forget to add the rest here
    }
}
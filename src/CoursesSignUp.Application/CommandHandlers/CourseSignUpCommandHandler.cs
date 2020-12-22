using System.Threading.Tasks;
using Chama.Infrastructure.Handlers.Interfaces;
using CourseSignUp.Contracts.Commands;
using CourseSignUp.Contracts.Requests;
using CourseSignUp.Contracts.ViewModels;

namespace CoursesSignUp.Application.CommandHandlers
{
    /// <summary>
    /// This is a CommandHandler for your SignUp-v2 implementation
    /// </summary>
    public class CourseSignUpCommandHandler : ICommandHandler<SignUpToCourseCommand>
    {
        public Task Handle(SignUpToCourseCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}
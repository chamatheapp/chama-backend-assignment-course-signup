using System.Threading.Tasks;
using Chama.Infrastructure.Handlers.Interfaces;
using CourseSignUp.Contracts.Requests;
using CourseSignUp.Contracts.ViewModels;

namespace CoursesSignUp.Application.OperationHandlers
{
    public class CourseSignUpOperationHandler: IOperationHandler<SignUpToCourseRequest, SignUpToCourseResponse>
    {
        public Task<SignUpToCourseResponse> Handle(SignUpToCourseRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
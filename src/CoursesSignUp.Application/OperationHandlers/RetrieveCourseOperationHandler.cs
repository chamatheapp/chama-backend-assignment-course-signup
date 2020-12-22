using System.Threading.Tasks;
using Chama.Infrastructure.Handlers.Interfaces;
using CourseSignUp.Contracts.Requests;
using CourseSignUp.Contracts.ViewModels;

namespace CoursesSignUp.Application.OperationHandlers
{
    public class RetrieveCourseOperationHandler : IOperationHandler<RetrieveCourseRequest, RetrieveCourseResponse>
    {
        public Task<RetrieveCourseResponse> Handle(RetrieveCourseRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
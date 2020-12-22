using System.Threading.Tasks;
using Chama.Infrastructure.Handlers.Interfaces;
using CourseSignUp.Contracts.Requests;
using CourseSignUp.Contracts.ViewModels;
using CourseSignUp.EntityFramework.Providers;
using CoursesSignUp.Core.Entities;

namespace CoursesSignUp.Application.OperationHandlers
{
    public class CreateCourseOperationHandler : IOperationHandler<CreateCourseRequest, CreateCourseResponse>
    {
        private readonly ICourseUnitOfWork _unitOfWork;

        public CreateCourseOperationHandler(ICourseUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<CreateCourseResponse> Handle(CreateCourseRequest request)
        {
            Course course = Course.Factory(request.Name, request.Capacity);

            _unitOfWork.Add(course);
            await _unitOfWork.CommitAsync();
            
            return new CreateCourseResponse()
            {
                Id = course.Id,
                Capacity = course.Capacity,
                Name = course.Name
            };
        }
    }
}
using System.Threading.Tasks;
using CoursesSignUp.Core.Entities;

namespace CourseSignUp.EntityFramework.Providers
{
    public interface ICourseUnitOfWork
    {
        Task<Course> GetAsync(string id);
        Course Add(Course entity);
        Task CommitAsync();
        Task<Course> GetByName(string name);
    }
}
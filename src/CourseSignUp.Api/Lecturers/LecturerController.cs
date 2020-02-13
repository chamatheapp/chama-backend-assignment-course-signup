using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CourseSignUp.Api.Lecturers
{
    [ApiController, Route("[controller]")]
    public class LecturersController : ControllerBase
    {
        [HttpPost, Route("create")]
        public Task<IActionResult> Post([FromBody]CreateLecturerDto createStudentDto)
        {
            throw new NotImplementedException();
        }
    }
}
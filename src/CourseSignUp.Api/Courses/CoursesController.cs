using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Courses
{
    [ApiController, Route("[controller]")]
    public class CoursesController : ControllerBase
    {
        [HttpGet, Route("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            // TODO
            return Ok(new CourseDto
            {

            });
        }

        [HttpPost, Route("create")]
        public Task<IActionResult> Post([FromBody]CreateCourseDto createCourseDto)
        {
            throw new NotImplementedException();
        }

        [HttpPost, Route("sign-up")]
        public Task<IActionResult> Post([FromBody] SignUpToCourseDto signUpToCourseDto)
        {
            throw new NotImplementedException();

        }
    }
}

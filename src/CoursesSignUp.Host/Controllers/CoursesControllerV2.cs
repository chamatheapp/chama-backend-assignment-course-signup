using System;
using System.Threading.Tasks;
using CourseSignUp.Contracts.Requests;
using Microsoft.AspNetCore.Mvc;

namespace CoursesSignUp.Host.Controllers
{
    [ApiController, Route("courses/v2")]
    public class CoursesV2Controller : ControllerBase
    {
        [HttpPost, Route("sign-up")]
        public Task<IActionResult> Post([FromBody] SignUpToCourseRequest signUpToCourseDto)
        {
            throw new NotImplementedException();
        }
    }
}
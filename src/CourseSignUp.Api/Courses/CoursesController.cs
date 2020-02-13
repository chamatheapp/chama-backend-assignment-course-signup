using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CourseSignUp.Api.Courses
{
    [ApiController]
    [Route("[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly ILogger<CoursesController> _logger;

        public CoursesController(ILogger<CoursesController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("sign-up")]
        public IActionResult Post([FromBody] SignUpModel signUpModel)
        {
            _logger.LogInformation($"Sign up student {signUpModel.Name} " +
                                   $"age {signUpModel.Age} " +
                                   $"into course {signUpModel.CourseId}.");
            
            return Accepted();
        }
    }
}

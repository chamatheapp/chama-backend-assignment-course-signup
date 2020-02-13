using Microsoft.AspNetCore.Mvc;

namespace CourseSignUp.Api.Analytics
{
    [ApiController]
    [Route("[controller]")]
    public class AnalyticsController : ControllerBase
    {
        [HttpGet]
        [Route("statistics")]
        public IActionResult GetStatistics()
        {
            return Ok(new CourseStatistics[]
            {
                new CourseStatistics
                {
                    MinimumAge = 1,
                    MaximumAge = 1,
                    AverageAge = 1,
                    Name = "C# (Advanced)"
                }, 
            });
        }
    }
}
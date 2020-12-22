using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CourseStatistics.Host.Controllers
{
    [ApiController, Route("[controller]")]
    public class StatisticsController : ControllerBase
    {
        [HttpGet]
        public Task<IActionResult> Get()
        {
            throw new NotImplementedException();
        }
    }
}
using System.Threading.Tasks;
using Chama.Infrastructure.Handlers.Interfaces;
using CourseSignUp.Contracts.Requests;
using CourseSignUp.Contracts.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CoursesSignUp.Host.Controllers
{
    [ApiController, Route("courses/v1")]
    public class CoursesController : ControllerBase
    {
        //TODO: Using a Mediatr Pattern without Mediatr... Can you install it and register?
        
        private readonly IOperationHandler<RetrieveCourseRequest, RetrieveCourseResponse>
            _retrieveCourseOperationHandler;

        private readonly IOperationHandler<SignUpToCourseRequest, SignUpToCourseResponse>
            _signUpToCourseOperationHandler;

        private readonly IOperationHandler<CreateCourseRequest, CreateCourseResponse>
            _createCourseOperationHandler;

        public CoursesController(
            IOperationHandler<RetrieveCourseRequest, RetrieveCourseResponse> retrieveCourseOperationHandler,
            IOperationHandler<SignUpToCourseRequest, SignUpToCourseResponse> signUpToCourseOperationHandler,
            IOperationHandler<CreateCourseRequest, CreateCourseResponse> createCourseOperationHandler)
        {
            _retrieveCourseOperationHandler = retrieveCourseOperationHandler;
            _signUpToCourseOperationHandler = signUpToCourseOperationHandler;
            _createCourseOperationHandler = createCourseOperationHandler;
        }

        [HttpGet, Route("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            RetrieveCourseResponse response = await _retrieveCourseOperationHandler.Handle(new RetrieveCourseRequest
            {
                Id = id
            });

            return Ok(response);
        }

        [HttpPost, Route("create")]
        public async Task<IActionResult> Post([FromBody] CreateCourseRequest request)
        {
            CreateCourseResponse response = await _createCourseOperationHandler.Handle(request);
            return Ok(response);
        }

        [HttpPost, Route("sign-up")]
        public async Task<IActionResult> Post([FromBody] SignUpToCourseRequest request)
        {
            SignUpToCourseResponse response = await _signUpToCourseOperationHandler.Handle(request);
            return Ok(response);
        }
    }
}
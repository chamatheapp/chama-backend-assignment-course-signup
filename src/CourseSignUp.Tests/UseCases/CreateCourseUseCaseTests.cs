using System;
using System.Threading.Tasks;
using AutoFixture;
using AutoFixture.Kernel;
using Chama.Infrastructure.Handlers.Interfaces;
using CourseSignUp.Contracts.Requests;
using CourseSignUp.Contracts.ViewModels;
using CourseSignUp.EntityFramework.Providers;
using CoursesSignUp.Application.OperationHandlers;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace CourseSignUp.Tests.UseCases
{
    [TestFixture]
    public class CreateCourseUseCaseTests
    {
        private Fixture _autoFixture;
        private CoursesDbContext _dbContext;

        [SetUp]
        public void Setup()
        {
            _autoFixture = new Fixture();
            var options = new DbContextOptionsBuilder<CoursesDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _dbContext = new CoursesDbContext(options);
            _autoFixture.Register(() => _dbContext);
            _autoFixture.Customizations.Add(new TypeRelay(typeof(ICourseUnitOfWork), typeof(CourseUnitOfWork)));
            _autoFixture.Customizations.Add(new TypeRelay(
                typeof(IOperationHandler<CreateCourseRequest, CreateCourseResponse>),
                typeof(CreateCourseOperationHandler)));
        }

        [Test(Description = "Asserts that a Course can be Created")]
        public async Task GivenValidCourseDetails_ShouldProduceANewCourse()
        {
            var sut = _autoFixture.Create<IOperationHandler<CreateCourseRequest, CreateCourseResponse>>();

            CreateCourseResponse response = await sut.Handle(new CreateCourseRequest()
            {
                Name = "Course",
                Capacity = 100
            });
            
            Assert.NotNull(response);
            Assert.NotNull(response.Id);
            Assert.AreEqual("Course", response.Name);
            Assert.AreEqual(100, response.Capacity);
        }
    }
}
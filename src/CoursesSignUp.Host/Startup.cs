using Chama.Infrastructure.Handlers.Interfaces;
using CourseSignUp.Contracts.Commands;
using CourseSignUp.Contracts.Requests;
using CourseSignUp.Contracts.ViewModels;
using CourseSignUp.EntityFramework.Providers;
using CoursesSignUp.Application.CommandHandlers;
using CoursesSignUp.Application.OperationHandlers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace CoursesSignUp.Host
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Chama",
                    Description = "Chama API Swagger surface",
                });
            });

            //Providers
            services.AddDbContext<CoursesDbContext>(options =>
                options
                    .EnableSensitiveDataLogging().UseInMemoryDatabase(databaseName: "CourseDbContext"));
            services.AddTransient<ICourseUnitOfWork, CourseUnitOfWork>();

            //OperationHandlers
            services
                .AddTransient<IOperationHandler<SignUpToCourseRequest, SignUpToCourseResponse>,
                    CourseSignUpOperationHandler>();
            services
                .AddTransient<IOperationHandler<CreateCourseRequest, CreateCourseResponse>, CreateCourseOperationHandler
                >();
            services
                .AddTransient<IOperationHandler<RetrieveCourseRequest, RetrieveCourseResponse>,
                    RetrieveCourseOperationHandler>();

            //CommandHandlers
            services
                .AddTransient<ICommandHandler<SignUpToCourseCommand>, CourseSignUpCommandHandler>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

            app.UseSwagger();
            app.UseSwaggerUI(s => { s.SwaggerEndpoint("/swagger/v1/swagger.json", "Chama Project API v1.0"); });
        }
    }
}
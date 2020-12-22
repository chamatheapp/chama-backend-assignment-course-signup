using System.Collections.Generic;
using System.Threading.Tasks;
using Chama.Domain.DomainExceptions;
using Chama.Infrastructure.Messaging.Interfaces;
using CoursesSignUp.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourseSignUp.EntityFramework.Providers
{
    public class CourseUnitOfWork : ICourseUnitOfWork
    {
        private CoursesDbContext DbContext { get; set; }
        private Course TrackedEntity { get; set; }

        public CourseUnitOfWork(CoursesDbContext dbContext)
        {
            DbContext = dbContext;
            CommittedCommands = new List<ICommand>();
            CommittedEvents = new List<IEvent>();
        }

        /// <summary>
        /// Used to Track which Events (Side Effects from the Domain) were Raised 
        /// </summary>
        public List<IEvent> CommittedEvents { get; private set; }
        
        /// <summary>
        /// Used to Track which Commands (Side Effects from the Domain) were Sent
        /// </summary>
        public List<ICommand> CommittedCommands { get; private set; }

        public async Task<Course> GetAsync(string id)
        {
            TrackedEntity = await DbContext.Courses.FindAsync(id);
            if (TrackedEntity == null) throw new NotFoundException("Could not locate specified key ",id);
            return TrackedEntity;
        }

        public Course Add(Course entity)
        {
            TrackedEntity = entity;
            DbContext.Courses.Add(entity);
            
            return TrackedEntity;
        }

        public Task CommitAsync()
        {
            CommittedCommands = TrackedEntity.UncommittedCommands;
            CommittedEvents = TrackedEntity.UncommittedEvents;
            TrackedEntity.ClearUncommittedMessages();

            return DbContext.SaveChangesAsync();
        }

        public Task<Course> GetByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
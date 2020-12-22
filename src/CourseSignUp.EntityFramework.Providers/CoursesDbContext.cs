using System.Threading.Tasks;
using CoursesSignUp.Core.Entities;
using CoursesSignUp.Core.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSignUp.EntityFramework.Providers
{
    public class CoursesDbContext : DbContext
    {
        public CoursesDbContext(DbContextOptions<CoursesDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            new CourseEntityTypeConfiguration().Configure(modelBuilder.Entity<Course>());
        }
    }

    public class CourseEntityTypeConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Id);
            
            builder.Property(c => c.Id).IsRequired();
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Capacity).IsRequired();
            builder
                .Ignore(c => c.UncommittedEvents)
                .Ignore(c => c.UncommittedCommands);
            //HINT: This is a good place to specify your Optimistic Concurrency Token
            //builder.Property(c => c.ConcurrencyToken).IsConcurrencyToken();


            builder.OwnsMany<Student>(c => c.EnrolledStudents);
        }
    }
}
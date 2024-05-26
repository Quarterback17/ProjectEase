using Microsoft.EntityFrameworkCore;

namespace ProjectEaseAPIWebApp.Models
{
    public class ProjectEaseAPIContext: DbContext
    {
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }

        public ProjectEaseAPIContext(DbContextOptions<ProjectEaseAPIContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }
    }
}

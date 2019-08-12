using Microsoft.EntityFrameworkCore;

namespace Registrar.Models
{
    public class RegistrarContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public DbSet<CourseStudent> CourseStudent { get; set; }

        public RegistrarContext(DbContextOptions options) : base(options) { }
    }
}
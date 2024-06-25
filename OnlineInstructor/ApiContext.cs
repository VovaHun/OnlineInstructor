using Microsoft.EntityFrameworkCore;
using OnlineInstructor.Data.Model;

namespace OnlineInstructor
{
    public class ApiContext : DbContext
    {
        DbSet<InstructorModel> Instructor { get; set; }
        DbSet<CustromerModel> Custromers { get; set; }
        DbSet<ExerciseModel> Exercise { get; set; }
        DbSet<ClassModel> Class { get; set; }

        DbSet<AdministratorModel> Administrators { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // использование Fluent API
            base.OnModelCreating(modelBuilder);
        }
    }
}

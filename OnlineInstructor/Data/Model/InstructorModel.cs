using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data.Entity.ModelConfiguration;

namespace OnlineInstructor.Data.Model
{
    public class InstructorModel : EntityTypeConfiguration<InstructorModel>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Descripron { get; set; } = "";

        public void Configure(EntityTypeBuilder<InstructorModel> builder)
        {
            builder.ToTable("Instructor").Property(x => x.Name).IsRequired();
            builder.ToTable("Instructor").Property(x => x.Login).IsRequired();
            builder.ToTable("Instructor").Property(x => x.Password).IsRequired();
           
        }
    }
}

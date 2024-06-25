using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data.Entity.ModelConfiguration;

namespace OnlineInstructor.Data.Model
{
    public class ClassModel : EntityTypeConfiguration<ClassModel>
    {
        public int Id { get; set; }
        public int IdExercise { get; set; }
        public int IdInstructor { get; set; }
        public TimeSpan TimeExercise { get; set; }
        public int Approches { get; set; }
        public bool AccomplishmentExecise { get; set; }
        public bool AccomplishmentClass { get; set; }
        public string? Description { get; set; } = null;


        public void Configure(EntityTypeBuilder<ClassModel> builder)
        {
            builder.ToTable("Class").Property(x => x.Description).HasMaxLength(500);

        }
    }
}

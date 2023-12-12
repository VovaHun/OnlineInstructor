

using System.Data.Entity.ModelConfiguration;

namespace OnlineInstructor.Data.Model
{
    public class CustromerModel : EntityTypeConfiguration<CustromerModel>
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public int? IdInstructor { get; set; } = null;
        public int? IdClass { get; set; } = null;

        public void Configure(EntityTypeConfiguration<CustromerModel> build)
        {
            build.ToTable("Customers").Property(x => x.Name).IsRequired();
            build.ToTable("Customers").Property(x => x.Login).IsRequired();
            build.ToTable("Customers").Property(x => x.Password).IsRequired();
            build.ToTable("Customers").Property(x => x.Phone).IsRequired();
            build.ToTable("Customers").Property(x => x.IdInstructor).IsOptional();
            build.ToTable("Customers").Property(x => x.IdClass).IsOptional();

        }



    }
}

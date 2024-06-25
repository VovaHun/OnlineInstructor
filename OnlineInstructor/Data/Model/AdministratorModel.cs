using System.Data.Entity.ModelConfiguration;

namespace OnlineInstructor.Data.Model
{
    public class AdministratorModel : EntityTypeConfiguration<AdministratorModel>
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}

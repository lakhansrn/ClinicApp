using System.Data.Entity;
using ClinicAppModels;

namespace ClinicAppDAL.DBContext
{
    public class ClinicAppDBContext : DbContext
    {
        public ClinicAppDBContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}

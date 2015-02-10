using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Clinic.Models.Mapping;

namespace Clinic.Models
{
    public class ClinicContext : DbContext
    {
        static ClinicContext()
        {
            Database.SetInitializer<ClinicContext>(null);
        }

        public ClinicContext()
            : base("Name=ClinicContext")
        {
            Configuration.AutoDetectChangesEnabled = true;
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = false;
            Configuration.ValidateOnSaveEnabled = true;
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Consultation> Consultations { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Secretary> Secretaries { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdminMap());
            modelBuilder.Configurations.Add(new ConsultationMap());
            modelBuilder.Configurations.Add(new DoctorMap());
            modelBuilder.Configurations.Add(new PatientMap());
            modelBuilder.Configurations.Add(new SecretaryMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}

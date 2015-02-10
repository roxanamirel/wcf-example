using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Clinic.Models.Mapping
{
    public class PatientMap : EntityTypeConfiguration<Patient>
    {
        public PatientMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IdentityCardNo)
                .HasMaxLength(50);

            this.Property(t => t.CNP)
                .HasMaxLength(50);

            this.Property(t => t.Address)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Patient");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.IdentityCardNo).HasColumnName("IdentityCardNo");
            this.Property(t => t.CNP).HasColumnName("CNP");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.Address).HasColumnName("Address");
        }
    }
}

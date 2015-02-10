using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Clinic.Models.Mapping
{
    public class DoctorMap : EntityTypeConfiguration<Doctor>
    {
        public DoctorMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Doctor");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.UserId).HasColumnName("UserId");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.Doctors)
                .HasForeignKey(d => d.UserId);

        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Clinic.Models.Mapping
{
    public class ConsultationMap : EntityTypeConfiguration<Consultation>
    {
        public ConsultationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Result)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Consultation");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PatientId).HasColumnName("PatientId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Result).HasColumnName("Result");
            this.Property(t => t.Hour).HasColumnName("Hour");

            // Relationships
            this.HasRequired(t => t.Doctor)
                .WithMany(t => t.Consultations)
                .HasForeignKey(d => d.DoctorId);
            this.HasRequired(t => t.Patient)
                .WithMany(t => t.Consultations)
                .HasForeignKey(d => d.PatientId);

        }
    }
}

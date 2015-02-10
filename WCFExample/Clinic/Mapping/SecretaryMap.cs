using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Clinic.Models.Mapping
{
    public class SecretaryMap : EntityTypeConfiguration<Secretary>
    {
        public SecretaryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Secretary");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.UserId).HasColumnName("UserId");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.Secretaries)
                .HasForeignKey(d => d.UserId);

        }
    }
}

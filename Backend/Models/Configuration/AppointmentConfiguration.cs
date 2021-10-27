using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Backend.Models.Configuration
{
    public class AppointmentConfiguration : EntityTypeConfiguration<Appointment>
    {
        public AppointmentConfiguration()
        {
            ToTable("Appointments");
            HasKey(x => x.AppointmentId)
                .Property(x => x.AppointmentId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(x => x.Pet)
                .WithMany()
                .Map(x => x.MapKey("PetId"));

            HasMany(x => x.Notes)
                .WithMany()
                .Map(x => x.MapLeftKey("AppointmentId").MapRightKey("NoteId").ToTable("AppointmentNotes"));

        }
    }
}

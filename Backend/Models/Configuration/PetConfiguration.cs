using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Backend.Models.Configuration
{
    public class PetConfiguration : EntityTypeConfiguration<Pet>
    {
        public PetConfiguration()
        {
            ToTable("Pets");
            HasKey(x => x.PetId)
                .Property(x => x.PetId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(x => x.Owner)
                .WithMany(x => x.Pets);

            HasRequired(x => x.Animal)
                .WithMany()
                .Map(x => x.MapKey("AnimalId"));

            HasMany(x => x.Notes)
                .WithMany()
                .Map(x => x.MapLeftKey("PetId").MapRightKey("NoteId").ToTable("PetNotes"));

        }
    }
}

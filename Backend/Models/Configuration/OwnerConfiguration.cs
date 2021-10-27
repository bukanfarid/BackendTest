using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Backend.Models.Configuration
{
    public class OwnerConfiguration : EntityTypeConfiguration<Owner>
    {
        public OwnerConfiguration()
        {
            ToTable("Owners");
            HasKey(x => x.OwnerId)
                .Property(x => x.OwnerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasMany(x => x.Pets)
                .WithRequired(x => x.Owner)
                .WillCascadeOnDelete(true);

            HasMany(x => x.Contacts)
                .WithMany()
                .Map(x => x.MapLeftKey("OwnerId").MapRightKey("ContactId").ToTable("OwnerContacts"));

            HasMany(x => x.Notes)
                .WithMany()
                .Map(x => x.MapLeftKey("OwnerId").MapRightKey("NoteId").ToTable("OwnerNotes"));

        }
    }
}
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend
{
    public class VetContext : DbContext
    {
        public VetContext(DbContextOptions<VetContext> options) : base(options) { }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Note> Notes { get; set; }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }


        /*public DbSet<Appointment> Appointments { get; set; }

         public VetContext(string connectionString = "NetVetConnectionString")
             : base(connectionString)
         { }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}

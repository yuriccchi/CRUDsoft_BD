using Microsoft.EntityFrameworkCore;

namespace ViewTree.Models
{
    internal class TreeContext : DbContext
    {
        public DbSet<PlantFamily> PlantFamilies { get; set; }
        public DbSet<PlantSpecies> PlantSpecies { get; set; }
        public DbSet<Plant> Plants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=SoftWEng;Username=postgres;Password=123654;Include Error Detail=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlantFamily>()
                .HasKey(pf => pf.FamilyID);

            modelBuilder.Entity<PlantFamily>()
                .HasMany(pf => pf.PlantSpecies)
                .WithOne(ps => ps.PlantFamily)
                .HasForeignKey(ps => ps.FamilyID);

            modelBuilder.Entity<PlantSpecies>()
                .HasKey(ps => ps.SpeciesID);

            modelBuilder.Entity<PlantSpecies>()
                .HasMany(ps => ps.Plants)
                .WithOne(p => p.PlantSpecies)
                .HasForeignKey(p => p.SpeciesID);

            modelBuilder.Entity<Plant>()
                .HasKey(p => p.PlantID);
        }
    }
}

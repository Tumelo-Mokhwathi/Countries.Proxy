using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Country.Proxy.Models
{
    public partial class CountriesDBContext : DbContext
    {
        public CountriesDBContext()
        {
        }

        public CountriesDBContext(DbContextOptions<CountriesDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Countries> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=CountriesDB;Trusted_Connection=True;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Countries>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Abbreviation).HasMaxLength(255);

                entity.Property(e => e.CountryName).HasMaxLength(255);

                entity.Property(e => e.CurrencyId).HasMaxLength(255);

                entity.Property(e => e.CurrencyName).HasMaxLength(255);

                entity.Property(e => e.CurrencySymbol).HasMaxLength(255);
            });
        }
    }
}

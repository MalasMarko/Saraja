using Microsoft.EntityFrameworkCore;
using Saraja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Saraja
{
    public class SarajaContext : DbContext
    {
        public DbSet<LegalEntity> LegalEntity;

        public SarajaContext(DbContextOptions options)
        {
        }
        public SarajaContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=sarajadb;database=saraja;user=root;password=saraja123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LegalEntity>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Description).IsRequired();
                entity.Property(e => e.Latitude).IsRequired();
                entity.Property(e => e.Longitude).IsRequired();
            });

            
        }

        public DbSet<Saraja.Models.LegalEntity> LegalEntity_1 { get; set; }
    }
}

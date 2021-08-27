using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HomeWorkEntity.Models
{
    public class HomeDbContext : DbContext
    {
        public HomeDbContext(DbContextOptions options) : base(options)
        {

        }

        public HomeDbContext()
        {
            Database.EnsureCreated();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Home;Integrated Security=True;");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Company>()
                .Property(i => i.Name)
                .IsRequired();

            modelBuilder.Entity<ArchitectProfile>()
                .HasOne(i => i.ArchitectRecord)
                .WithOne(i => i.Profile)
                .HasForeignKey<ArchitectProfile>(i => i.ArchitectRecordId);

            modelBuilder.Entity<Company>()
                .HasMany(i => i.Architects)
                .WithOne(i => i.Company)
                .HasForeignKey(i => i.CompanyId);

            modelBuilder.Entity<Architect>()
                .HasMany(i => i.Engineers)
                .WithMany(i => i.Architects)
                .UsingEntity(i => i.ToTable("EngineersArchitects"));
        }

        public virtual DbSet<Architect> Architects { get; set; }
        public virtual DbSet<Engineer> Engineers { get; set; }
        public virtual DbSet<Company> Companys { get; set; }
        public virtual DbSet<ArchitectProfile> ArchitectProfiles { get; set; }
    }
}

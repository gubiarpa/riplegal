using Microsoft.EntityFrameworkCore;
using ripley.legal.entities.Models;
using ripley.legal.repository.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ripley.legal.repository
{
    public class DbContextApp : DbContext
    {
        public DbSet<LawFirm> LawFirms { get; set; }
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<ProcessType> ProcessTypes { get; set; }
        public DbSet<Claimer> Claimers { get; set; }
        public DbSet<Defendant> Defendants { get; set; }
        public DbSet<Typology> Typologies { get; set; }
        public DbSet<LegalPosition> LegalPositions { get; set; }
        public DbSet<DefenseAssessment> DefenseAssessments { get; set; }

        public DbContextApp(DbContextOptions<DbContextApp> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new LawFirmMap());
            modelBuilder.ApplyConfiguration(new CityMap());
            modelBuilder.ApplyConfiguration(new AgencyMap());
            modelBuilder.ApplyConfiguration(new CityMap());
            modelBuilder.ApplyConfiguration(new ProcessTypeMap());
            modelBuilder.ApplyConfiguration(new ClaimerMap());
            modelBuilder.ApplyConfiguration(new DefendantMap());
            modelBuilder.ApplyConfiguration(new TypologyMap());
            modelBuilder.ApplyConfiguration(new LegalPositionMap());
            modelBuilder.ApplyConfiguration(new DefendantMap());
        }
    }
}

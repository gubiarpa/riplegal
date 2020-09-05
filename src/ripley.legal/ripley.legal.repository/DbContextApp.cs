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

        public DbContextApp(DbContextOptions<DbContextApp> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new LawFirmMap());
        }
    }
}

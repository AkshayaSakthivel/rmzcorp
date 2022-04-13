using Microsoft.EntityFrameworkCore;
using RMZCorp.DataAccess.SQL.DataModels;
using System;

namespace RMZCorp.DataAccess.SQL
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options): base (options)
        {

        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<ElectricityMeter> ElectricityMeters { get; set; }
        public DbSet<WaterMeter> WaterMeters { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-2VHJJA3;Initial Catalog=RMZCorpDB;Integrated Security=True");
        //}
    }
}

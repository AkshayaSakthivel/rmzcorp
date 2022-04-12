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

        DbSet<City> Cities { get; set; }
        DbSet<Facility> Facilities { get; set; }
        DbSet<Building> Buildings { get; set; }
        DbSet<Floor> Floors { get; set; }
        DbSet<Zone> Zones { get; set; }
        DbSet<ElectricityMeter> ElectricityMeters { get; set; }
        DbSet<WaterMeter> WaterMeters { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-2VHJJA3;Initial Catalog=RMZCorpDB;Integrated Security=True");
        //}
    }
}

using DL.Entities;
using DL.Maps;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class WineryDB : DbContext
    {
        public WineryDB()
        : base(AppConfiguration.ConnectionString)
        {
        }

        public DbSet<BottleSize> BottleSizes { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<SubType> SubTypes { get; set; }
        public DbSet<Types> Types { get; set; }
        public DbSet<Wine> Wines { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BottleSizeMap());
            modelBuilder.Configurations.Add(new RegionMap());
            modelBuilder.Configurations.Add(new SubTypeMap());
            modelBuilder.Configurations.Add(new TypeMap());
            modelBuilder.Configurations.Add(new WineMap());


        }
    }
}

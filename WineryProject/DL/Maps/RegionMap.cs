using DL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Maps
{
    public class RegionMap : EntityTypeConfiguration<Region>
    {
        public RegionMap()
        {
            ToTable("Region");

            //Primary Key

            HasKey(w => w.RegionID);
            Property(w => w.RegionID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Properties
            Property(w => w.RegionName).HasMaxLength(50).IsRequired();

        }
    }
}

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
    public class BottleSizeMap : EntityTypeConfiguration<BottleSize>
    {
        public BottleSizeMap()
        {
            ToTable("BottleSize");
            //primary key

            HasKey(w => w.BottleSizeID);
            Property(w => w.BottleSizeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Properties
            Property(w => w.Size).IsRequired();
        }
    }
}

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
    public class SubTypeMap : EntityTypeConfiguration<SubType>
    {
        public SubTypeMap()
        {
            ToTable("SubType");
            //Primary Key

            HasKey(w => w.SubTypeID);
            Property(w => w.SubTypeID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Properties
            Property(w => w.SubTypeName).HasMaxLength(20).IsRequired();
        }
    }
}

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
    public class TypeMap : EntityTypeConfiguration<Types>
    {
        public TypeMap()
        {
            ToTable("Types");
            //Primary Key

            HasKey(w => w.TypeID);
            Property(w => w.TypeID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Properties
            Property(w => w.TypeName).HasMaxLength(20).IsRequired();
        }
    }
}

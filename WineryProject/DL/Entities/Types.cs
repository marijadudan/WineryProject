using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Entities
{
      
        public class Types
        {
            public int TypeID { get; set; }
            public string TypeName { get; set; }

            public ICollection<Wine> Wines { get; set; }
        }
    
}

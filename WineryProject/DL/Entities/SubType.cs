using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Entities
{
    public class SubType
    {
        public int SubTypeID { get; set; }
        public string SubTypeName { get; set; }
        //mapped
        public ICollection<Wine> Wines { get; set; }
    }
}

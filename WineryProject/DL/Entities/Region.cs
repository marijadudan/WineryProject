using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Entities
{
    public class Region
    {
        public int RegionID { get; set; }
        public string RegionName { get; set; }

        //mapped
        public ICollection<Wine> Wines { get; set; }
    }
}

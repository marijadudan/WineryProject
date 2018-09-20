using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Entities
{
    public class BottleSize
    {
        public int BottleSizeID { get; set; }
        public int Size { get; set; }

        //mapped
        public ICollection<Wine> Wines { get; set; }
    }
}

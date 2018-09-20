using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Entities
{
    public class Country
    {
        public int CountryID{ get; set; }
        public string CountryName {get; set; }

        //mapped
        public ICollection<Wine> Wines { get; set; }

    }
}

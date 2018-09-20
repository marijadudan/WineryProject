using DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Winery.Models
{
    public class WineViewModel
    {
        public WineViewModel()
        {

        }
        public WineViewModel(Wine wine)
        {
            WineID = wine.WineID;
            TypeID = wine.TypeID;
            RegionID = wine.RegionID;
            CountryID = wine.CountryID;
            BottleSizeID = wine.BottleSizeID;
            SubTypeID = wine.SubTypeID;
            Vintage = wine.Vintage;
            Name = wine.Name;
            Description = wine.Description;
            ImagePath = wine.ImagePath;
            
        }


        public int WineID { get; set; }
        public int TypeID { get; set; }
        public int RegionID { get; set; }
        public int CountryID { get; set; }
        public int BottleSizeID { get; set; }
        public int SubTypeID { get; set; }
        public int Vintage { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }


        public string Types { get; set; }
        public string RegionName { get; set; }
        public string CountryName { get; set; }
        public string SubTypes { get; set; }
        
    }
}
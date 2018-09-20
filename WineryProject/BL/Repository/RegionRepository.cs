using BL.Interfaces;
using DL;
using DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Repository
{
    public class RegionRepository : IRegion
    {
        private WineryDB db;

        public RegionRepository()
        {
            db = new WineryDB();
        }

        public void Delete(Region region)
        {
            if (region == null) return;
            db.Regions.Remove(region);
            db.SaveChanges();
        }

        public void Delete(int regionID)
        {
            Delete(GetByID(regionID));
        }

       

        public bool Exist(int regionID)
        {
            return db.Regions.Any(t => t.RegionID == regionID);
        }

        public bool Exists(int region)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Region> GetAll()
        {
            return db.Regions;
        }

        public Region GetByID(int ID)
        {
            return db.Regions.SingleOrDefault(w => w.RegionID == ID);
        }

        public void Insert(Region region)
        {
            if (region == null) return;
            db.Regions.Add(region);
            db.SaveChanges();
        }

       

        public void Update(Region region)
        {
            if (region != null && Exists(region.RegionID))
            {
                db.SaveChanges();
            }
        }

        

      
    }
}

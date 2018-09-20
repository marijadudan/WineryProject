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
    public class BottleSizeRerpository : IBottleSize
    {

        private WineryDB db;

        public BottleSizeRerpository()
        {
            db = new WineryDB();
        }

        public void Delete(BottleSize bottlesize)
        {
            if (bottlesize == null) return;
            db.BottleSizes.Remove(bottlesize);
            db.SaveChanges();
        }

        public void Delete(int bottlesizeID)
        {
            Delete(GetByID(bottlesizeID));
        }


        public bool Exists(int bottlesizeID)
        {
            return db.BottleSizes.Any(t => t.BottleSizeID == bottlesizeID);
        }

     

        public IQueryable<BottleSize> GetAll()
        {
            return db.BottleSizes;
        }

        public BottleSize GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public void Insert(BottleSize bottlesize)
        {
            if (bottlesize == null) return;
            db.BottleSizes.Add(bottlesize);
            db.SaveChanges();
        }

        public void Update(BottleSize bottlesize)
        {
            if (bottlesize != null && Exists(bottlesize.BottleSizeID))
            {
                db.SaveChanges();
            }
        }

    }
}

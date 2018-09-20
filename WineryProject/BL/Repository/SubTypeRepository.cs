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
    public class SubTypeRepository : ISubTypeRepository
    {


        private WineryDB db;
        public SubTypeRepository()
        {
            db = new WineryDB();
        }

        public void Delete(SubType subtype)
        {
            if (subtype == null) return;
            db.SubTypes.Remove(subtype);
            db.SaveChanges();
        }

        public void Delete(int subtypeID)
        {
            Delete(GetByID(subtypeID));
        }

        public bool Exists(int subtypeID)
        {
            return db.SubTypes.Any(t => t.SubTypeID == subtypeID);
        }

        public IQueryable<SubType> GetAll()
        {
            return db.SubTypes;
        }

        public SubType GetByID(int ID)
        {
            return db.SubTypes.SingleOrDefault(w => w.SubTypeID == ID);
        }

        public void Insert(SubType subtype)
        {
            if (subtype == null) return;
            db.SubTypes.Add(subtype);
            db.SaveChanges();
        }

        public void Update(SubType subtype)
        {
            if (subtype != null && Exists(subtype.SubTypeID))
            {
                db.SaveChanges();
            }
        }
    }
}

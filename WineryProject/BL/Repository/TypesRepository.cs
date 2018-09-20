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
    public class TypesRepository : ITypesRepository
    {

        private WineryDB db;
        public TypesRepository()
        {
            db = new WineryDB();
        }
        public List<Types> GetTypes()
        {
            return db.Types.ToList();
        }
        public void Delete(Types type)
        {
            if (type == null) return;
            db.Types.Remove(type);
            db.SaveChanges();
        }

        public void Delete(int typeID)
        {
            Delete(GetByID(typeID));
        }

     

        public bool Exists(int typeID)
        {
            return db.Types.Any(t => t.TypeID == typeID);
        }

      

        public Types GetByID(int ID)
        {
            return db.Types.SingleOrDefault(w => w.TypeID == ID);
        }

        public void Insert(Types type)
        {
            if (type == null) return;
            db.Types.Add(type);
            db.SaveChanges();
        }

        

        public void Update(Types type)
        {
            if (type != null && Exists(type.TypeID))
            {
                db.SaveChanges();
            }
        }

        

        IQueryable<Types> GetAll()
        {
            throw new NotImplementedException();
        }

        Types ITypesRepository.GetByID(int ID)
        {
            throw new NotImplementedException();
        }
    }
}

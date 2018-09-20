using DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface ITypesRepository
    {
      
        Types GetByID(int ID);
        void Insert(Types type);
        void Update(Types type);
        void Delete(Types type);
        void Delete(int typeID);
        bool Exists(int typeID);
        List<Types> GetTypes();
    }
}

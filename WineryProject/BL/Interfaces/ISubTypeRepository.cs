using DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface ISubTypeRepository
    {
        IQueryable<SubType> GetAll();
        SubType GetByID(int ID);
        void Insert(SubType subtype);
        void Update(SubType subtype);
        void Delete(SubType subtype);
        void Delete(int subtype);
        bool Exists(int subtype);
    }
}

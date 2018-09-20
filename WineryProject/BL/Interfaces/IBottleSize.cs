using DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IBottleSize
    {
        IQueryable<BottleSize> GetAll();
        BottleSize GetByID(int ID);
        void Insert(BottleSize bottlesize);
        void Update(BottleSize bottlesize);
        void Delete(BottleSize bottlesize);
        void Delete(int region);
        bool Exists(int region);

       
    }
}

using DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IRegion
    {
        IQueryable<Region> GetAll();
        Region GetByID(int ID);
        void Insert(Region region);
        void Update(Region region);
        void Delete(Region region);
        void Delete(int region);
        bool Exists(int region);
    }
}

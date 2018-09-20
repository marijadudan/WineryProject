using DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IWineRepository
    {
        List<Wine> GetAll();
        Wine GetByID(int ID);
        void Insert(Wine wine);
        void Update(Wine wine);
        void Delete(Wine wine);
        void Delete(int wineID);
        bool Exists(int wineID);
    }
}

using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IRecyleObjectsService
    {
        void RecyleObjectAdd(RecyleObjects recyleObjects);
        void CoiColRemove(RecyleObjects RecyleObjects);
        void CoinColUpdate(RecyleObjects recyleObjects);
        List<RecyleObjects> GetAllPoints();
        RecyleObjects GetById(int id);
        RecyleObjects GetByAdress(string adress);
    }
}

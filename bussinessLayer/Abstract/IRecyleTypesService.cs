using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IRecyleTypesService
    {
        void RecyleTypeAdd(RecyleTypes reType);
        void RecyleTypeRemove(RecyleTypes reType);
        void REcyleTypeUpdate(RecyleTypes reType);
        List<RecyleTypes> GetAllTypes();

        RecyleTypes GetById(int id);
        RecyleTypes GetByAdress(string adress);
    }
}

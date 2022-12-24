using BussinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class RecyleTypesManeger : IRecyleTypesService
    {
        IRecyleTypesDal _types;

        public RecyleTypesManeger(IRecyleTypesDal types)
        {
            _types = types;
        }

        public List<RecyleTypes> GetAllTypes()
        {
            return _types.GetListAll();
        }

        public RecyleTypes GetByAdress(string adress)
        {
            throw new NotImplementedException();
        }

        public RecyleTypes GetById(int id)
        {
            return _types.GetById(id);
        }

        public void RecyleTypeAdd(RecyleTypes reType)
        {
            _types.Insert(reType);
        }

        public void RecyleTypeRemove(RecyleTypes reType)
        {
            _types.Delete(reType);
        }

        public void REcyleTypeUpdate(RecyleTypes reType)
        {
            _types.Update(reType);
        }
    }
}

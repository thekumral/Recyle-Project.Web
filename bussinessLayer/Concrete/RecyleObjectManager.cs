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
    public class RecyleObjectManager : IRecyleObjectsService
    {
        IRecyleObjectDal _ReObject;

        public RecyleObjectManager(IRecyleObjectDal reObject)
        {
            _ReObject = reObject;
        }

        public void CoiColRemove(RecyleObjects RecyleObjects)
        {
            _ReObject.Delete(RecyleObjects);
        }

        public void CoinColUpdate(RecyleObjects recyleObjects)
        {
            _ReObject.Update(recyleObjects);
        }

        public List<RecyleObjects> GetAllPoints()
        {
            return _ReObject.GetListAll();
        }

        public RecyleObjects GetByAdress(string adress)
        {
            throw new NotImplementedException();
        }

        public RecyleObjects GetById(int id)
        {
            return _ReObject.GetById(id);
        }

        public void RecyleObjectAdd(RecyleObjects recyleObjects)
        {
            _ReObject.Insert(recyleObjects);
        }
    }
}

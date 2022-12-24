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
    public class CoinCollectionPointManager : ICoinCollectionService
    {
        ICoinCollectionPointDal _point;

        public CoinCollectionPointManager(ICoinCollectionPointDal point)
        {
            _point = point;
        }

        public void CoiColRemove(CoinCollectionPoint ccpoint)
        {
            _point.Delete(ccpoint);
        }

        public void CoinColAdd(CoinCollectionPoint ccpoint)
        {
            _point.Insert(ccpoint);
        }

        public void CoinColUpdate(CoinCollectionPoint ccpoint)
        {
            _point.Update(ccpoint);
        }

        public List<CoinCollectionPoint> GetAllPoints()
        {
            return _point.GetListAll();
        }

        public CoinCollectionPoint GetByAdress(string adress)
        {
            throw new NotImplementedException();
        }

        public CoinCollectionPoint GetById(int id)
        {
            return _point.GetById(id);
        }
    }
}

using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
    public class CoinCollectionPointRepository : ICoinCollectionPointDal
    {
        public void Delete(CoinCollectionPoint t)
        {
            throw new NotImplementedException();
        }

        public CoinCollectionPoint GetByAdress(string adress)
        {
            throw new NotImplementedException();
        }

        public CoinCollectionPoint GetByID(int id)
        {
            using var context = new Context();
            return context.coinCollectionPoints.Find(id);
        }

        public CoinCollectionPoint GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CoinCollectionPoint> GetListAll()
        {
            using var context = new Context();
            return context.coinCollectionPoints.ToList();
        }

        public void Insert(CoinCollectionPoint t)
        {
            using var context = new Context();
            context.coinCollectionPoints.Add(t);
            context.SaveChanges();
        }

        public void Update(CoinCollectionPoint t)
        {
            using var context=new Context();
            context.coinCollectionPoints.Update(t);
            context.SaveChanges();
        }
    }
}

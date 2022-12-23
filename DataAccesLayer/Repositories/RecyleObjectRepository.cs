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
    public class RecyleObjectRepository : IRecyleObjectDal
    {
        public void Delete(RecyleObjects t)
        {
            throw new NotImplementedException();
        }

        public RecyleObjects GetByID(int id)
        {
            using var context = new Context();
            return context.recyleObjects.Find(id);
        }

        public RecyleObjects GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<RecyleObjects> GetListAll()
        {
            using var context = new Context();
            return context.recyleObjects.ToList();
        }

        public void Insert(RecyleObjects t)
        {
            using var context=new Context();
            context.recyleObjects.Add(t);
            context.SaveChanges();
        }

        public void Update(RecyleObjects reobject)
        {
            using var context = new Context();
            context.Update(reobject);
            context.SaveChanges();
        }
    }
}

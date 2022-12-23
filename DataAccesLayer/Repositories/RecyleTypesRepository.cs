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
    public class RecyleTypesRepository : IRecyleTypesDal
    {
        public void Delete(RecyleTypes t)
        {
            using var context =new Context();
            context.recyletypes.Remove(t);
            context.SaveChanges();
        }

        public RecyleTypes GetById(int id)
        {
            using var context=new Context();
            return context.recyletypes.Find(id);

        }

        public List<RecyleTypes> GetListAll()
        {
            using var context= new Context();
            return context.recyletypes.ToList();
        }

        public void Insert(RecyleTypes t)
        {
            using var context = new Context();
            context.recyletypes.Add(t);
            context.SaveChanges();
        }

        public void Update(RecyleTypes t)
        {
            using var context = new Context();
            context.recyletypes.Update(t);
            context.SaveChanges();
        }
    }
}

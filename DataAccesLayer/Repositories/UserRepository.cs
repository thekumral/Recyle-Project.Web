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
    public class UserRepository : IUserDal
    {
        public void Delete(User t)
        {
            using var context = new Context(); 
            context.users.Remove(t);
            context.SaveChanges();
        }

        public User GetByAdress(string adress)
        {
            throw new NotImplementedException();
        }

        public User GetByID(int id)
        {
            using var context= new Context();
            
            return context.users.Find(id);
            
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetListAll()
        {
            using var context = new Context();
            return context.users.ToList();
        }

        public void Insert(User t)
        {
            using var context = new Context();
            context.users.Add(t);
            context.SaveChanges();
        }

        public void Update(User t)
        {
            using var context = new Context();
            context.users.Update(t);
            context.SaveChanges();
        }
    }
}

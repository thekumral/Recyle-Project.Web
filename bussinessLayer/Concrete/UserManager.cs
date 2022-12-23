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
    public class UserManager : IUserService
    {
        IUserDal _user;

        public UserManager(IUserDal user)
        {
            _user = user;
        }

        public List<User> GetAllUser()
        {
            return _user.GetListAll();
        }

        public User GetById(int id)
        {
            return _user.GetById(id);
        }

        public void USerAdd(User user)
        {
            _user.Insert(user);
        }

        public void USerRemove(User user)
        {
            _user.Delete(user);
        }

        public void UserUpdate(User user)
        {
            _user.Update(user);
        }
    }
}

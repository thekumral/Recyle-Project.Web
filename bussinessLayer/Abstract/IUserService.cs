using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IUserService
    {
        void USerAdd(User user);
        void USerRemove(User user);
        void UserUpdate(User user);
        List<User> GetAllUser();
        User GetById(int id);
    }
}

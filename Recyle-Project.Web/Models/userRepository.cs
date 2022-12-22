using System.Security.Cryptography;

namespace Recyle_Project.Web.Models
{
    public class userRepository
    {
        private static List<user> _user = new List<user>() { };
        public void Add(user newUsers) => _user.Add(newUsers);
    }
}

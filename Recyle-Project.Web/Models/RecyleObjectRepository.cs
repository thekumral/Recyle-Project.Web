using EntityLayer.Concrete;

namespace Recyle_Project.Web.Models
{
    public class RecyleObjectRepository
    {
        private static List<User> _books = new List<User>()
        {
            //new (){Id=1,Name="Ömerin Suçu NE",Stock=100,Year=2012},
            //new (){Id=2,Name="Sql hate You *:(",Stock=200,Year=2009},
            //new (){Id=1,Name="Ömerin çilesi",Stock=999,Year=2022}

        };
        public List<User> GetAll() => _books;

        public void Update(User Updateuser)
        {
            var SonUser = _books.FirstOrDefault(x => x.SendAddress.ToString()== Updateuser.walletAddress.ToString());
            if (SonUser == null)
            {
                throw new Exception($"Bu id({Updateuser.walletAddress})'ye sahip Cüzdan Adresi bulunmamaktadir.");
            }
            //SonUser.ReValueWallet+=SonUser.SendValue
            //hasBook.ReName = updateBook.ReName;
            //hasBook.ReValue= updateBook.ReValue;
            //hasBook.ImagePath = updateBook.ImagePath;

            //var index = _books.FindIndex(x => x.ObjectID== updateBook.ObjectID);

            //_books[index] = hasBook;
        }
    }

}

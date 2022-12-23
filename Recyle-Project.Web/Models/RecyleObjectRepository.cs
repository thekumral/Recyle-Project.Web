using EntityLayer.Concrete;

namespace Recyle_Project.Web.Models
{
    public class RecyleObjectRepository
    {
        private static List<RecyleObjects> _books = new List<RecyleObjects>()
        {
            //new (){Id=1,Name="Ömerin Suçu NE",Stock=100,Year=2012},
            //new (){Id=2,Name="Sql hate You *:(",Stock=200,Year=2009},
            //new (){Id=1,Name="Ömerin çilesi",Stock=999,Year=2022}

        };
        public List<RecyleObjects> GetAll() => _books;
        public void Add(RecyleObjects newBook) => _books.Add(newBook);
        public void Remove(int id)
        {
            var hasBook = _books.FirstOrDefault(x => x.ObjectID == id);
            if (hasBook == null)
            {
                throw new Exception($"Bu id({id})'ye sahip kitap bulunmamaktadir.");
            }
            _books.Remove(hasBook);
        }
        public void Update(RecyleObjects updateBook)
        {
            var hasBook = _books.FirstOrDefault(x => x.ObjectID == updateBook.ObjectID);
            if (hasBook == null)
            {
                throw new Exception($"Bu id({updateBook.ObjectID})'ye sahip kitap bulunmamaktadir.");
            }
            hasBook.ReName = updateBook.ReName;
            hasBook.ReValue= updateBook.ReValue;
            hasBook.ImagePath = updateBook.ImagePath;

            var index = _books.FindIndex(x => x.ObjectID== updateBook.ObjectID);

            _books[index] = hasBook;
        }
    }

}

namespace Recyle_Project.Web.Models
{
    public class recyleObjectsRepository<T>
    {
        private static List<recyleObjects> _reObject= new List<recyleObjects>() { };
        public List<recyleObjects> GetAll() => _reObject;
        public void Getobject(int id)
        {
            var hasObject=_reObject.FirstOrDefault(x=>x.ObjectID== id);
            
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Recyle_Project.Web.Models
{
    public class Recyletype
    {
        [Key]
        public int TypeID { get; set; }
        public string Name { get; set; }
    }
}

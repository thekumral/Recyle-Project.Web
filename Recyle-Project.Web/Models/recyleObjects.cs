using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recyle_Project.Web.Models
{
    public class recyleObjects
    {
        [Key]
        public int ObjectID { get; set; }
        public string ReName { get; set; }
        public int ReValue { get; set; }
        public string ImagePath { get; set; }
        public string Reİnfo { get; set; }
        public string quotes { get; set; }
        [ForeignKey("Recyletype")]
        public int TypeID { get; set; }
        public Recyletype Recyletype { get; set; }
    }
}

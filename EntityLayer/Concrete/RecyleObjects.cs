using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class RecyleObjects
    {
        [Key]
        public int ObjectID { get; set; }
        public string ReName { get; set; }
        public int ReValue { get; set; }
        public string ImagePath { get; set; }
        public int RecyleObjectUser { get; set; }
        public string Reİnfo { get; set; }
        public string quotes { get; set; }
        [ForeignKey("Recyletype")]
        public int TypeID { get; set; }
        public RecyleTypes Recyletype { get; set; }
    }
}

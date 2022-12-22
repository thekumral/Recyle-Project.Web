using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace Recyle_Project.Web.Models
{
    public class user
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        [StringLength(100)]
        public string password { get; set; }

        [StringLength(300)]
        
        public string walletAddress { get; set; } 

        public string phoneNumber { get; set; }


    }
   
}

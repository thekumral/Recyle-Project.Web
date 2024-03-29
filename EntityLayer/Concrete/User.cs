﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        
        public string userName { get; set; }
        
        [StringLength(100)]
        public string password { get; set; }

        [StringLength(300)]

        public string walletAddress { get; set; }

        public string phoneNumber { get; set; }

        public int ReValueWallet { get; set; }
        public string ProfileImage { get; set; }
        public int SendValue { get; set; }
        public string SendAddress { get; set; }

    }
}

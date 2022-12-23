using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    [Keyless]
    public class CoinCollectionPoint
    {
        public int NameId { get; set; }
        public int CoinTotal { get; set; }
    }
}

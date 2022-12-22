using MessagePack;
using Microsoft.EntityFrameworkCore;

namespace Recyle_Project.Web.Models
{
    [Keyless]
    public class coinCollectionPoint
    {
        public int NameId { get; set; }
        public int CoinTotal { get; set; }
    }
}

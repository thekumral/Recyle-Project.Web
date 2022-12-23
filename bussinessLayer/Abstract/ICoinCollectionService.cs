using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
namespace BussinessLayer.Abstract
{
    public interface ICoinCollectionService
    {
        void CoinColAdd(CoinCollectionPoint ccpoint);
        void CoiColRemove(CoinCollectionPoint ccpoint);
        void CoinColUpdate(CoinCollectionPoint ccpoint);
        List<CoinCollectionPoint> GetAllPoints();
        CoinCollectionPoint GetById(int id);
    }
}

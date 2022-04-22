using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public class ShipperManager : GenericManager<Shipper, DtoShipper>,IShipperService
    {
        IQueryable<DtoShipper> IShipperService.GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}

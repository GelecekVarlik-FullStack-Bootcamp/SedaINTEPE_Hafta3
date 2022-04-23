using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System.Linq;


namespace Northwind.Bll
{
    public class ShipperManager : GenericManager<Shipper, DtoShipper>,IShipperService
    {
        IQueryable<DtoShipper> IShipperService.GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}

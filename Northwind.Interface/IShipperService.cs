using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface IShipperService : IGenericService<Shipper, DtoShipper>
    {
        IQueryable<DtoShipper> GetTotalReport();
    }
}

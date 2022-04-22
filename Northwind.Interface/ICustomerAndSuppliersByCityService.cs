using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface ICustomerAndSuppliersByCityService : IGenericService<CustomerAndSuppliersByCity, DtoCustomerAndSuppliersByCity>
    {
        IQueryable<DtoCustomerAndSuppliersByCity> GetTotalReport();
    }
}

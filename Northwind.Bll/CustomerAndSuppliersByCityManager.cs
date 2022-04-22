using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public class CustomerAndSuppliersByCityManager : GenericManager<CustomerAndSuppliersByCity, DtoCustomerAndSuppliersByCity>, ICustomerAndSuppliersByCityService
    {
        public IQueryable<DtoCustomerAndSuppliersByCity> GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}

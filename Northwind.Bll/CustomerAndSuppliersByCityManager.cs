using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System.Linq;


namespace Northwind.Bll
{
    public class CustomerAndSuppliersByCityManager : GenericManager<CustomerAndSuppliersByCity, DtoCustomerAndSuppliersByCity>, ICustomerAndSuppliersByCityService
    {
        public IQueryable<DtoCustomerAndSuppliersByCity> GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}

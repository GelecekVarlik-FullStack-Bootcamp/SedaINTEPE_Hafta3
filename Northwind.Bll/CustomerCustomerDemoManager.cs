using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public class CustomerCustomerDemoManager : GenericManager<CustomerCustomerDemo, DtoCustomerCustomerDemo>, ICustomerCustomerDemoService
    {
        public IQueryable<DtoCustomerCustomerDemo> GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}


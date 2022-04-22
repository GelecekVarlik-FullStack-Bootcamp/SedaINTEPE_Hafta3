using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface ICustomerCustomerDemoService : IGenericService<CustomerCustomerDemo, DtoCustomerCustomerDemo>
    {
        IQueryable<DtoCustomerCustomerDemo> GetTotalReport();
    }
}


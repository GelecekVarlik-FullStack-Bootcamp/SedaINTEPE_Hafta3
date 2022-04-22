using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface ICustomerDemographicService : IGenericService<CustomerDemographic, DtoCustomerDemographic>
    {
        IQueryable<DtoCustomerDemographic> GetTotalReport();
    }
}


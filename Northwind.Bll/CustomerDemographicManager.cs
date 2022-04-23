using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System.Linq;


namespace Northwind.Bll
{
    public class CustomerDemographicManager : GenericManager<CustomerDemographic, DtoCustomerDemographic>, ICustomerDemographicService
    {
        public IQueryable<DtoCustomerDemographic> GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}


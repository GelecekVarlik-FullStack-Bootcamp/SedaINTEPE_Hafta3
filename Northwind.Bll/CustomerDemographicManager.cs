using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public class CustomerDemographicManager : GenericManager<CustomerDemographic, DtoCustomerDemographic>,ICustomerDemographicService
    {
       
        IQueryable<DtoCustomerDemographic> ICustomerDemographicService.GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}


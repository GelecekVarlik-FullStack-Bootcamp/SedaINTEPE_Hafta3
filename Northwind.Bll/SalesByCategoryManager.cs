using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public class SalesByCategoryManager : GenericManager<SalesByCategory, DtoSalesByCategory>,ISalesByCategoryService
    {
      
        IQueryable<DtoSalesByCategory> ISalesByCategoryService.GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}

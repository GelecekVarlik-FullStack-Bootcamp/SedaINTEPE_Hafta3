using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System.Linq;


namespace Northwind.Bll
{
    public class SalesByCategoryManager : GenericManager<SalesByCategory, DtoSalesByCategory>,ISalesByCategoryService
    {
      
        IQueryable<DtoSalesByCategory> ISalesByCategoryService.GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}

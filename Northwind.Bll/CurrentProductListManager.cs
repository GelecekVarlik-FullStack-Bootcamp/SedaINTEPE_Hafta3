using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System.Linq;


namespace Northwind.Bll
{
    public class CurrentProductListManager : GenericManager<CurrentProductList, DtoCurrentProductList>,ICurrentProductListService
    {
      
        IQueryable<DtoCurrentProductList> ICurrentProductListService.GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}

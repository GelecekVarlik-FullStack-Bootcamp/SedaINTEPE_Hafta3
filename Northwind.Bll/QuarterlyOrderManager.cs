using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public class QuarterlyOrderManager : GenericManager<QuarterlyOrder, DtoQuarterlyOrder>,IQuarterlyOrderService
    {
       
        IQueryable<DtoQuarterlyOrder> IQuarterlyOrderService.GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}

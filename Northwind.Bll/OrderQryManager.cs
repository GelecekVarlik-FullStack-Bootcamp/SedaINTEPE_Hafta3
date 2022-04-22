using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public class OrderQryManager : GenericManager<OrdersQry, DtoOrdersQry>,IOrderQryService
    {
        
        IQueryable<DtoOrdersQry> IOrderQryService.GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}


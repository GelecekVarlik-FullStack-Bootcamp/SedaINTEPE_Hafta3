using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System.Linq;


namespace Northwind.bll
{
    public class OrderQryManager : GenericManager<OrdersQry, DtoOrdersQry>,IOrderQryService
    {
        
        IQueryable<DtoOrdersQry> IOrderQryService.GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}


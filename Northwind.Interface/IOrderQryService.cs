using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface IOrderQryService : IGenericService<OrdersQry, DtoOrdersQry>
    {
        IQueryable<DtoOrdersQry> GetTotalReport();
    }
}


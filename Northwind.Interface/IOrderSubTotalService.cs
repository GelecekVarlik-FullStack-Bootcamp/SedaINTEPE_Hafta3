using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface IOrderSubTotalService : IGenericService<OrderSubtotal, DtoOrderSubtotal>
    {
        IQueryable<DtoOrderSubtotal> GetTotalReport();
    }
}

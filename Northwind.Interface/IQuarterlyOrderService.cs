using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface IQuarterlyOrderService : IGenericService<QuarterlyOrder, DtoQuarterlyOrder>
    {
        IQueryable<DtoQuarterlyOrder> GetTotalReport();
    }
}

using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface IOrderDetailsExtendedService : IGenericService<OrderDetailsExtended, DtoOrderDetailsExtended>
    {
        IQueryable<DtoOrderDetailsExtended> GetTotalReport();
    }
}


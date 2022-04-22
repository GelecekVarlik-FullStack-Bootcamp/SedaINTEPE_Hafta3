using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface IOrderDetailService : IGenericService<OrderDetail, DtoOrderDetail>
    {
        IQueryable<DtoOrderDetail> GetTotalReport();
    }
}


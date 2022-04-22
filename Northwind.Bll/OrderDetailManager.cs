using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public class OrderDetailManager : GenericManager<OrderDetail, DtoOrderDetail>, IOrderDetailService
    {
        public IQueryable<DtoOrderDetail> GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}


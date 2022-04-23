using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System.Linq;


namespace Northwind.Bll
{
    public class OrderDetailManager : GenericManager<OrderDetail, DtoOrderDetail>, IOrderDetailService
    {
        public IQueryable<DtoOrderDetail> GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}


using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public class OrderManager : GenericManager<Order, DtoOrder>, IOrderService
    {
        public IQueryable<DtoOrder> GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}


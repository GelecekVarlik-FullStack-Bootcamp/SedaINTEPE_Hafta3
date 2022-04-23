using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System.Linq;


namespace Northwind.Bll
{
    public class OrderManager : GenericManager<Order, DtoOrder>, IOrderService
    {
        public IQueryable<DtoOrder> GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}


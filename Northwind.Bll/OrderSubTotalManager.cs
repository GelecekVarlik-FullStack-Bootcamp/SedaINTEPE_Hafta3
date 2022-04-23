using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System.Linq;


namespace Northwind.Bll
{
    public class OrderSubTotalManager : GenericManager<OrderSubtotal, DtoOrderSubtotal>, IOrderSubTotalService
    {
        public IQueryable<DtoOrderSubtotal> GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}

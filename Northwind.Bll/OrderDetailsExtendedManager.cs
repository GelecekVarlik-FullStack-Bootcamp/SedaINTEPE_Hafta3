using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System.Linq;


namespace Northwind.Bll
{
    public class OrderDetailsExtendedManager : GenericManager<OrderDetailsExtended, DtoOrderDetailsExtended>, IOrderDetailsExtendedService
    {
        public IQueryable<DtoOrderDetailsExtended> GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}


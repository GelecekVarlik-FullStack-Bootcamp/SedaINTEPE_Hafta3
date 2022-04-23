using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class OrderDetailsExtendedRepository : GenericRepository<OrderDetailsExtended>, IOrderDetailsExtendedRepository
    {
        public OrderDetailsExtendedRepository(DbContext context) : base(context) //base: kalıtım aldığı yere gider
        {

        }
        public IQueryable<OrderDetailsExtended> GetTotalReport()//:this() //const const a veri gondermek için kullanılır
        {
            return dbset.AsQueryable();
        }
    }
}

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
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContext context) : base(context) //base: kalıtım aldığı yere gider
         {

         }
        public IQueryable<Customer> GetTotalReport()//:this() //const const a veri gondermek için kullanılır
        {
            return dbset.AsQueryable();
        }
    }
}

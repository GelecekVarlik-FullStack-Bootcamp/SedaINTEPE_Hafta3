using Northwind.Entity.Models;
using System.Linq;
using Northwind.Dal.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class CategorySalesFor1997Repository : GenericRepository<CategorySalesFor1997>, ICategorySalesFor1997Repository
    {
        public CategorySalesFor1997Repository(DbContext context) : base(context)
        {

        }
        public IQueryable<CategorySalesFor1997> GetTotalReport()
        {
            return dbset.AsQueryable();
        }
    }
}

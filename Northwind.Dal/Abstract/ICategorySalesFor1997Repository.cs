using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Dal.Abstract
{
    public interface ICategorySalesFor1997Repository
    {
        IQueryable<CategorySalesFor1997> GetTotalReport();
    }
}

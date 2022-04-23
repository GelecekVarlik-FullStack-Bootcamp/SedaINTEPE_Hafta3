using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Dal.Abstract
{
    public interface IProductsSalesFor1997Repository 
    {
        IQueryable<CategorySalesFor1997> GetTotalReport();
    }
}

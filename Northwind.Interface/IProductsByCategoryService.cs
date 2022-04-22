using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface IProductsByCategoryService : IGenericService<ProductsByCategory, DtoProductsByCategory>
    {
        IQueryable<DtoProductsByCategory> GetTotalReport();
    }
}


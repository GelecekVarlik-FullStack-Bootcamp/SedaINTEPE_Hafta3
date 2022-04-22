using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface IProductService : IGenericService<Product, DtoProduct>
    {
        IQueryable<DtoProduct> GetTotalReport();
    }
}

using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface ISalesByCategoryService : IGenericService<SalesByCategory, DtoSalesByCategory>
    {
        IQueryable<DtoSalesByCategory> GetTotalReport();
    }
}

using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface ICurrentProductListService : IGenericService<CurrentProductList, DtoCurrentProductList>
    {
        IQueryable<DtoCurrentProductList> GetTotalReport();
    }
}

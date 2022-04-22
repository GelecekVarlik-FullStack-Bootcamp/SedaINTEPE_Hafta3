using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface IProductsSalesFor1997Service : IGenericService<ProductSalesFor1997, DtoProductSalesFor1997>
    {
        IQueryable<DtoCategorySalesFor1997> GetTotalReport();
    }
}

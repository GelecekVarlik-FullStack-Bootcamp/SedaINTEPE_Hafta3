using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public class ProductManager : GenericManager<Product, DtoProduct>,IProductService
    {
      
        IQueryable<DtoProduct> IProductService.GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}

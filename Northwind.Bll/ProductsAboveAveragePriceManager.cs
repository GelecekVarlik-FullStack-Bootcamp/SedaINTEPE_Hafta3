using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public class ProductsAboveAveragePriceManager : GenericManager<ProductsAboveAveragePrice, DtoProductsAboveAveragePrice>, IProductsAboveAveragePriceService
    {
        public IQueryable<DtoProductsAboveAveragePrice> GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}

using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public class ProductsByCategoryManager : GenericManager<ProductsByCategory, DtoProductsByCategory>, IProductsByCategoryService
    {
        public IQueryable<DtoProductsByCategory> GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}


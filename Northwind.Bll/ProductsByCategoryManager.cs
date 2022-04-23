using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System.Linq;


namespace Northwind.Bll
{
    public class ProductsByCategoryManager : GenericManager<ProductsByCategory, DtoProductsByCategory>, IProductsByCategoryService
    {
        public IQueryable<DtoProductsByCategory> GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}


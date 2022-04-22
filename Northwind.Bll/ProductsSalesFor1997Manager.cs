using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public class ProductsSalesFor1997Manager : GenericManager<ProductSalesFor1997, DtoProductSalesFor1997>,IProductsSalesFor1997Service
    {
       
        IQueryable<DtoCategorySalesFor1997> IProductsSalesFor1997Service.GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}

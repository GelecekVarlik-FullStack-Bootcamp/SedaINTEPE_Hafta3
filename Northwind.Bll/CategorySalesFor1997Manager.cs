using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System.Linq;


namespace Northwind.Bll
{
    public class CategorySalesFor1997Manager : GenericManager<CategorySalesFor1997, DtoCategorySalesFor1997>, ICategorySalesFor1997Service
    {
        public IQueryable<DtoCategorySalesFor1997> GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}

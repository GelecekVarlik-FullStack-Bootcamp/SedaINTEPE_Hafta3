using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System.Linq;


namespace Northwind.Bll
{
    public class SummaryOfSalesByYearManager : GenericManager<SummaryOfSalesByYear, DtoSummaryOfSalesByYear>, ISummaryOfSalesByYearService
    {
        public IQueryable<DtoSummaryOfSalesByYear> GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}

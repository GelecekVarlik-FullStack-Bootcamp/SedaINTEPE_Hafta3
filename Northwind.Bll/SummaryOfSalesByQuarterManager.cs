using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System.Linq;


namespace Northwind.Bll
{
    public class SummaryOfSalesByQuarterManager : GenericManager<SummaryOfSalesByQuarter, DtoSummaryOfSalesByQuarter>,ISummaryOfSalesByQuarterService
    {  
        IQueryable<DtoSummaryOfSalesByQuarter> ISummaryOfSalesByQuarterService.GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}

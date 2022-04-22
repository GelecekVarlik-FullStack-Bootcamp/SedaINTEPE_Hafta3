using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface ISummaryOfSalesByQuarterService : IGenericService<SummaryOfSalesByQuarter, DtoSummaryOfSalesByQuarter>
    {
        IQueryable<DtoSummaryOfSalesByQuarter> GetTotalReport();
    }
}

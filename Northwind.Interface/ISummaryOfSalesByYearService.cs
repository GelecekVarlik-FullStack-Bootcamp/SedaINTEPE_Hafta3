using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface ISummaryOfSalesByYearService : IGenericService<SummaryOfSalesByYear, DtoSummaryOfSalesByYear>
    {
        IQueryable<DtoSummaryOfSalesByYear> GetTotalReport();
    }
}

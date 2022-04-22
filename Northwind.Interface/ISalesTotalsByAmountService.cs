using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface ISalesTotalsByAmountService : IGenericService<SalesTotalsByAmount, DtoSalesTotalsByAmount>
    {
        IQueryable<DtoSalesTotalsByAmount> GetTotalReport();
    }
}

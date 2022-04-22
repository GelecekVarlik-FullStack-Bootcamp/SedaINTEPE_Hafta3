using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface IRegionService : IGenericService<Region, DtoRegion>
    {
        IQueryable<DtoRegion> GetTotalReport();
    }
}

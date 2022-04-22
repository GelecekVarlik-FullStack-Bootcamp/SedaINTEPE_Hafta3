using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public class RegionManager : GenericManager<Region, DtoRegion>, IRegionService
    {
        public IQueryable<DtoRegion> GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}

using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System.Linq;


namespace Northwind.Bll
{
    public class RegionManager : GenericManager<Region, DtoRegion>, IRegionService
    {
        public IQueryable<DtoRegion> GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}

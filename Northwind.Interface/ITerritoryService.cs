using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface ITerritoryService : IGenericService<Territory, DtoTerritory>
    {
        IQueryable<DtoTerritory> GetTotalReport();
    }
}

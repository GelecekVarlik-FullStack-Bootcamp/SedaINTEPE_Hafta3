using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System.Linq;


namespace Northwind.Bll
{
    public class TerritoryManager : GenericManager<Territory, DtoTerritory>,ITerritoryService
    { 
        IQueryable<DtoTerritory> ITerritoryService.GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}

using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public class EmployeeTerritoryManager : GenericManager<EmployeeTerritory, DtoEmployeeTerritory>,IEmployeeTerritoryService
    {
        IQueryable<DtoEmployeeTerritory> IEmployeeTerritoryService.GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}


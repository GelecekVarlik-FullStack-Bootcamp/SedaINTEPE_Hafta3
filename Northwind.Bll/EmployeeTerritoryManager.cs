using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System.Linq;


namespace Northwind.Bll
{
    public class EmployeeTerritoryManager : GenericManager<EmployeeTerritory, DtoEmployeeTerritory>,IEmployeeTerritoryService
    {
        IQueryable<DtoEmployeeTerritory> IEmployeeTerritoryService.GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}


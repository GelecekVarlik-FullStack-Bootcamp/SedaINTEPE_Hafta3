﻿using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface IEmployeeTerritoryService : IGenericService<EmployeeTerritory, DtoEmployeeTerritory>
    {
        IQueryable<DtoEmployeeTerritory> GetTotalReport();
    }
}


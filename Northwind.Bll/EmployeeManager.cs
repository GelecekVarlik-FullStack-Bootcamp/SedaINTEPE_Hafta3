using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System.Linq;


namespace Northwind.Bll
{
    public class EmployeeManager : GenericManager<Employee, DtoEmployee>,IEmployeeService
    {
        
        IQueryable<DtoEmployee> IEmployeeService.GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}


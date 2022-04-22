using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface IEmployeeService : IGenericService<Employee, DtoEmployee>
    {
        IQueryable<DtoEmployee> GetTotalReport();
    }
}


using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public interface IUserService : IGenericService<User, DtoUser>
    {
        IQueryable<DtoUser> GetTotalReport();
    }
}

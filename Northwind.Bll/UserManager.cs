using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using System.Linq;

namespace Northwind.Bll
{
    public class UserManager : GenericManager<User, DtoUser>, IUserService
    {
        public IQueryable<DtoUser> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}

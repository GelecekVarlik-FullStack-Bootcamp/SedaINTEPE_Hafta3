using Northwind.Entity.Models;
using System.Linq;
using Northwind.Dal.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class AlphabeticalListOfProductRepository : GenericRepository<AlphabeticalListOfProduct>, IAlphabeticalListOfProductRepository
    {
        public AlphabeticalListOfProductRepository(DbContext context) : base(context) 
        {

        }
        public IQueryable<AlphabeticalListOfProduct> GetTotalReport()
        {
            return dbset.AsQueryable();
        }
    }
}

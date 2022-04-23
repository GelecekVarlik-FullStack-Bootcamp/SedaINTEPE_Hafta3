using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface ICategoryRepository
    {
        //orneğin boyle bir method verdik modele,ortak olamayn ozellik
        IQueryable<Category> GetTotalReport();
    }
}

using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;

namespace Northwind.Interface
{
    public class CategoryManager : GenericManager<Category, DtoCategory>, ICategoryService
    {
        //orneğin boyle bir method verdik modele,ortak olamayn ozellik
        public IQueryable<DtoCategory> GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}

using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;

namespace Northwind.Interface
{
    public interface ICategoryService:IGenericService<Category,DtoCategory>
    {
        //orneğin boyle bir method verdik modele,ortak olamayn ozellik
        IQueryable<DtoCategory> GetTotalReport();
    }
}

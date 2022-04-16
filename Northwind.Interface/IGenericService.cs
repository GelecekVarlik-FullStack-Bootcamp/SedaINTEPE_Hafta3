using Northwind.Entity.Base;
using Northwind.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Interface
{//ortak olan işlmler burada toplanacak..
    //T modeli kabul eder genelde adı T olmasda ollur ama genel olara T kabul edilir.
    public interface IGenericService<T, TDto>where T:IEntityBase where TDto:IDtoBase
    {
        //listeleme
        IResponse<List<TDto>> GetAll();
        //filtreli listeleme
        IResponse<List<TDto>> GetAll(Expression<Func<T,bool>> expression);
        //getirme işlermi
        IResponse<TDto> Find(int id);
        //kaydetme

        IResponse<TDto> Add(TDto item, bool saveChanges = true);//
        //async kydetme

       Task<IResponse<TDto>> AddAsync(TDto item, bool saveChanges = true);//

        //gunellemee
        IResponse<TDto> Update(TDto item, bool saveChanges = true);
        //async guncelleme

        Task<IResponse<TDto>> UpdateAsync(TDto item, bool saveChanges = true);
        //silme
        IResponse<bool> DeleteById(int id, bool saveChanges = true);
        //async silme
        Task<IResponse<bool>> DeleteByIdAsync(int id, bool saveChanges = true);

        //IQueryaple listeleme
        IQueryable<TDto> GetQueryable();
    }
}

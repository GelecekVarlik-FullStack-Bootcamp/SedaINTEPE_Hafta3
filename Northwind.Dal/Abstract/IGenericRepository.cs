using Northwind.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Abstract
{
    //interface ise I
    public interface IGenericRepository<T> where T : IEntityBase
    {
        //listeleme
        List<T> GetAll();
        //filtreli listeleme
        List<T> GetAll(Expression<Func<T, bool>> expression);
        //getirme işlermi
         T Find(int id);
        //kaydetme

        T Add(T item);//
            //filtreli kaydetmee                                                    //async kydetme

        Task<T> AddAsync(T item);//

        //gunellemee
        T Update(T item);
        //async guncelleme

       // Task<T> UpdateAsync(T item);
        //silme
        bool Delete(int id);
        bool Delete(T item);
        //async silme
      //  Task<bool> DeleteByIdAsync(int id);

        //IQueryaple listeleme
        IQueryable<T> GetQueryable();
    }
}

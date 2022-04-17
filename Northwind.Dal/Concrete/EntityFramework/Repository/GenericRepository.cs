using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    


    public class GenericRepository<T> : IGenericRepository<T> where T : EntityBase
    {
        #region Variables
        protected DbContext context;//default olarak private gelir
        protected DbSet<T> dbset;
        #endregion
        public GenericRepository(DbContext context)//?
        {
            this.context = context;
            this.dbset = this.context.Set<T>();

       //     this.context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;//Bu veriyi al ama üzerinde değişiklik yapma yada sınırlı sayıda değişiklik demek
        }
        #region Methods
        public T Add(T item)
        {
            context.Entry(item).State = EntityState.Added;
            dbset.Add(item);

            return item;
        }

        public async Task<T> AddAsync(T item)
        {
            context.Entry(item).State = EntityState.Added;
            await dbset.AddAsync(item);

            return item;
        }

        public bool Delete(T item)
        {
           // var item = Find(id);
            if (context.Entry(item).State == EntityState.Detached)
            {
                context.Attach(item);
            }
            return dbset.Remove(item) != null;
            
        }

        public bool Delete(int id)
        {
            return Delete(Find(id));
        }

        //public async Task<bool> DeleteByIdAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public T Find(int id)
        {
            //Find PK ya gore calısır.
            return dbset.Find(id);
        }

        public List<T> GetAll()
        {
            return dbset.ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return dbset.Where(expression).ToList();
        }

        public IQueryable<T> GetQueryable()
        {
            return dbset.AsQueryable();
        }

        public T Update(T item)
        {
            dbset.Update(item);
            //context.SaveChanges(); //bu işlem unitofworks ile gercekleştirirz.
            return item; //Bu guncel halini return eder
        }

        //public async Task<T> UpdateAsync(T item)
        //{
        //    dbset.
        //}
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public abstract class Repository<T> : IDisposable where T : class
    {
        protected RPP22_07_DBEntities Context { get; set; }
        protected DbSet<T> Entities { get; set; }
        public Repository(RPP22_07_DBEntities context)
        {
            this.Context = context;
            Entities = context.Set<T>();
        }

        public virtual IQueryable<T> GetAll()
        {
            var query = from x in Entities
                        select x;
            return query;
        }

        public virtual int Add(T entity)
        {
            Entities.Add(entity);
            return SaveChanges();
        }

        public virtual int Update(T entity) { return 0; }

        public virtual int Delete(T entity)
        {
            Entities.Attach(entity);
            Entities.Remove(entity);
            return SaveChanges();
        }

        public virtual int SaveChanges()
        {
            return Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}


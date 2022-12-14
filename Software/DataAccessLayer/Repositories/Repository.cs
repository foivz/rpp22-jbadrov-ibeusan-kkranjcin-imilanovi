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
        protected LibResModel context { get; set; }
        protected DbSet<T> Entities { get; set; }
        public Repository(LibResModel context)
        {
            this.context = context;
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

        public abstract int Update(T entity);

        public virtual int Delete(T entity)
        {
            Entities.Attach(entity);
            Entities.Remove(entity);
            return SaveChanges();
        }

        public virtual int SaveChanges()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}


using RepositoryPattern.DataMapper;
using RepositoryPattern.Interfaces.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DAL
{
    abstract class BaseRepository<T> : IRepository<T>
        where T : class
    {
        public virtual IEnumerable<T> Get(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "")
        {
            using (var ctx = new MyContext())
            {
                var dbSet = ctx.Set<T>();

                IQueryable<T> query = dbSet;

                if (filter != null)
                {
                    query = query.Where(filter);
                }

                foreach (var includeProperty in includeProperties.Split
                    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }

                if (orderBy != null)
                {
                    return orderBy(query).ToList();
                }
                else
                {
                    return query.ToList();
                }
            }
        }

        public virtual void Insert(T entity)
        {
            using (var ctx = new MyContext())
            {
                var dbSet = ctx.Set<T>();
                dbSet.Add(entity);
                
                ctx.SaveChanges();
            }
        }

        public virtual void Update(T item)
        {
            using (var ctx = new MyContext())
            {
                var dbSet = ctx.Set<T>();
                dbSet.Attach(item);
                ctx.Entry(item).State = EntityState.Modified;

                ctx.SaveChanges();
            }
        }

        public virtual void Delete(object id)
        {
            Delete(GetByID(id));
        }

        public virtual void Delete(T entityToDelete)
        {
            using (var ctx = new MyContext())
            {
                var dbSet = ctx.Set<T>();

                if (ctx.Entry(entityToDelete).State == EntityState.Detached)
                {
                    dbSet.Attach(entityToDelete);
                }

                dbSet.Remove(entityToDelete);

                ctx.SaveChanges();
            }
        }

        public virtual T GetByID(object id)
        {
            using (var ctx = new MyContext())
            {
                return ctx.Set<T>().Find(id);
            }
        }
    }
}

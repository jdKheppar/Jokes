using Jokes.Data;
using Jokes.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace Jokes.Repository
{
    public class Repository<T> : IRepository<T> where T : class

    {
        public readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
            //_db.Categories == dbSet like we did previously
        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public T Get(System.Linq.Expressions.Expression<System.Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            query = query .Where(filter);
            return query.SingleOrDefault();
        }

        public System.Collections.Generic.IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(System.Collections.Generic.IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }
    }
}

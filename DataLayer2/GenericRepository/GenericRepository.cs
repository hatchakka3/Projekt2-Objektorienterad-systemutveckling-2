using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        public OSU2Context context = null;
        public DbSet<TEntity> table = null;

        public GenericRepository(OSU2Context _context)
        {
            this.context = _context;
            table = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return table.ToList();
        }

        public TEntity GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(TEntity obj)
        {
            table.Add(obj);
            context.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            table.Attach(obj);
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(object id)
        {
            TEntity exisiting = table.Find(id);
            table.Remove(exisiting);
            context.SaveChanges();
        }
    }
}

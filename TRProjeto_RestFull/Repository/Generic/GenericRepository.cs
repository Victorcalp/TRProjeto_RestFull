using Microsoft.EntityFrameworkCore;
using Projeto_RestFull.Model.Base;
using System.Collections.Generic;
using System.Linq;
using TRProjeto_RestFull.Model.Context;

namespace TRProjeto_RestFull.Repository.Generic
{
    public class GenericRepository<T> : IGeneric<T> where T : BaseEntity
    {
        private readonly MYSQLContext _context;
        private DbSet<T> dbSet;

        public GenericRepository(MYSQLContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }

        public T Create(T item)
        {
            if(item == null) return null;
            
            dbSet.Add(item);
            _context.SaveChanges();
            return item;   
        }
        public T Update(T item)
        {
            if (item == null) return null;

            dbSet.Update(item);
            _context.SaveChanges();
            return item;
        }

        public void Delete(long id)
        {
            var result = dbSet.SingleOrDefault(x=> x.Id == id);
            dbSet.Remove(result);
            _context.SaveChanges();
        }

        public List<T> FiendAll()
        {
            return dbSet.ToList();
        }

        public T FiendById(long id)
        {
            return dbSet.SingleOrDefault(x=> x.Id == id);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using News.CodeFirst;
using News.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryPattern
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly NewsDbContext dbContext;
        protected DbSet<T> entities;
        public GenericRepository()
        {
            dbContext = new NewsDbContext();
            entities = dbContext.Set<T>();
        }
        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity to Add is null");
            }
            entities.Add(entity);
            dbContext.SaveChanges();
        }

        public void AddRange(IEnumerable<T> entities)
        {
            foreach (var item in entities)
            {
                Add(item);
            }
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T GetById(int id)
        {
            return entities.SingleOrDefault(e => e.Id == id);
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                ArgumentNullException argumentNullException = new ArgumentNullException("entity to Remove is null");
                throw argumentNullException;
            }
            entities.Remove(entity);
            dbContext.SaveChanges();
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            foreach (var item in entities)
            {
                Remove(item);
            }
        }

        //Finds element with entity.Id in context and updates it
        public void Update(T entity)
        {
            dbContext.SaveChanges();
        }
    }
}

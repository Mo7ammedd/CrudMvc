using System.Collections.Generic;
using System.Linq;
using BLL.Interfaces;
using DAL.Data;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositries
{
    public class GenaricRepository<T> : IGenaricRepository<T> where T : BaseModel
    {
        private protected AppDbContext _dbContext;
        public GenaricRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext ; 
        }
        public int Add(T entity)
        {
            _dbContext.Add(entity);
            return _dbContext.SaveChanges();
        }
        public int Update(T entity)
        {
            _dbContext.Update(entity);
            return _dbContext.SaveChanges();
        }
        public int Delete(T entity)
        {
            _dbContext.Remove(entity);
            return _dbContext.SaveChanges();
        }

        public T Get(int id)
        {
            return _dbContext.Find<T>(id);
        }

        public IEnumerable<T> GetAll()
            => _dbContext.Set<T>().AsNoTracking().ToList();         
        
    }
}
using System.Collections.Generic;
using System.Linq;
using BLL.Interfaces;
using DAL.Data;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repositries
{
    public class EmployeeRepository : GenaricRepository<Employee> ,IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public IQueryable<Employee> GetEmployeesByAddress(string address)
        {
            return _dbContext.Employees.Where(e => e.Address.ToLower().Contains(address.ToLower()));
        }

      
    }
}
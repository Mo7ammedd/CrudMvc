using System.Collections.Generic;
using System.Linq;
using DAL.Models;

namespace BLL.Interfaces
{
    public interface IEmployeeRepository : IGenaricRepository<Employee>
    {
        IQueryable <Employee> GetEmployeesByAddress(string address);
      
    }
}
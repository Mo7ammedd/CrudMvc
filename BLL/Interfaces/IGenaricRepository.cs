using System.Collections.Generic;
using DAL.Models;

namespace BLL.Interfaces
{
    public interface IGenaricRepository <T> where T : BaseModel
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        int Add (T entity);
        int Update (T entity);
        int Delete(T entity);
    }
}
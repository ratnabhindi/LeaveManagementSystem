using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        ICollection<T> GetAll();

        T FindById(int id);

        bool Exists(int id);

        bool Add(T entity);

        bool Update(T entity);

        bool Delete(T entity);

        bool Save();
    }
}
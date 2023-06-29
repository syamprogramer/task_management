using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Core.Interfaces
{
    //create interface IGenericRepository with generic type T
    public interface IGenericRepository<T> where T : class
    {
        //create method GetAll
        Task<IEnumerable<T>> GetAll();
        //create method GetById
        Task<T> GetById(int id);
        //create method Add
        Task Add(T entity);
        //create method Update
        Task Update(T entity);
        //create method Delete



        
        Task Delete(T entity);
    }
}

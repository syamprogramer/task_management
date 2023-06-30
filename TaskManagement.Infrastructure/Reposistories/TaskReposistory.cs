using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.Interfaces;
using TaskManagement.Core.Reposistories;
using TaskManagement.Data;
 
using Entities = TaskManagement.Core.Entities;
namespace TaskManagement.Infrastructure.Reposistories
{

    //create class TaskReposistory for Task 
    public class TaskReposistory :  ITaskReposistory
    {
        private readonly ApplicationDbContext _dbContext;


        public TaskReposistory(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //create method GetAll

        public async Task<IEnumerable<Entities.Task>> GetAll()
        {
            return _dbContext.Task.Include("AssignedToUser").ToList();
        }
        //create method GetById
        public async Task<Entities.Task> GetById(int id)
        {

            return _dbContext.Task.Where(x => x.Id == id).FirstOrDefault();

        }


        public async Task Add(Entities.Task entity)
        {
            _dbContext.Task.Add(entity);
          var res= _dbContext.SaveChanges();
        }

        public async Task Update(Entities.Task entity)
        {
            _dbContext.Task.Update(entity);
            _dbContext.SaveChanges();
        }

        public async Task Delete(Entities.Task entity)
        {
            _dbContext.Task.Remove(entity);
            _dbContext.SaveChanges();
        }

        //create method GetByUserId
        public async Task<IEnumerable<Entities.Task>> GetByUserId(int userId)
        {
            return _dbContext.Task.Where(x => x.AssignedTo == userId).ToList();
        }
    }


}

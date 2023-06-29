using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.Reposistories;
using TaskManagement.Core.Services;

namespace TaskManagement.Application.Services
{

    //Generate class TaskService with constructor parameter ITaskReposistory with function GetAll, GetById, Add, Update, Delete
    public class TaskService : ITaskService
    {
        private readonly ITaskReposistory _taskReposistory;
        
        public TaskService(ITaskReposistory taskReposistory)
        {
            _taskReposistory = taskReposistory;
        }

        public async Task<IEnumerable<Core.Entities.Task>> GetAll()
        {
            return await _taskReposistory.GetAll();
        }

        public async Task<Core.Entities.Task> GetById(int id)
        {
            return await _taskReposistory.GetById(id);
        }

        public async Task Add(Core.Entities.Task entity)
        {
            await _taskReposistory.Add(entity);
        }

        public async Task Update(Core.Entities.Task entity)
        {
            await _taskReposistory.Update(entity);
        }

        public async Task Delete(Core.Entities.Task entity)
        {
            await _taskReposistory.Delete(entity);
        }
    }

}




namespace TaskManagement.Core.Reposistories
{
    public interface ITaskReposistory
    {
     

        Task Add(Core.Entities.Task entity);
        Task Delete(Core.Entities.Task entity);
        Task<IEnumerable<Core.Entities.Task>> GetAll();
        Task<Core.Entities.Task> GetById(int id);
        Task Update(Core.Entities.Task entity);
    }
}
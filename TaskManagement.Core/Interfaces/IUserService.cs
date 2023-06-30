

using TaskManagement.Core.Entities;

namespace TaskManagement.Application.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();
    }
}
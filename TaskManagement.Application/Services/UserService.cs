
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.Entities;
using TaskManagement.Core.Interfaces;

namespace TaskManagement.Application.Services
{
     //generate class UserService with constructor parameter IUserReposistory with function GetAll
     public class UserService : IUserService
    {
        private readonly Core.Interfaces.IUserReposistory _userReposistory;
        
        public UserService(IUserReposistory userReposistory)
        {
            _userReposistory = userReposistory;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _userReposistory.GetAll();
        }
    }
}

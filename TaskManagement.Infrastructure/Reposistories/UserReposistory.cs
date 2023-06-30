using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManagement.Core.Entities;
using TaskManagement.Core.Interfaces;
using TaskManagement.Data;

namespace TaskManagement.Infrastructure.Reposistories
{
    public class UserReposistory:IUserReposistory
    {
        //generate class UserReposistory with constructor parameter ApplicationDbContext
        private readonly ApplicationDbContext _dbContext;
        //constructor userReposistory with parameter ApplicationDbContext
        public UserReposistory(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //create method GetAll
        public async Task<IEnumerable<User>> GetAll()
        {
            return _dbContext.Users.ToList();
        }
    }
}

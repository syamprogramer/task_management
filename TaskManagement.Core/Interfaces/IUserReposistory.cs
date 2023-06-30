using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.Entities;

namespace TaskManagement.Core.Interfaces
{
    public interface IUserReposistory
    {
        //Generate interface IUserReposistory with function GetAll
        Task<IEnumerable<User>> GetAll();
        

    }
}

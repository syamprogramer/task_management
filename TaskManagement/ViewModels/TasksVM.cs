using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.ViewModels
{

    public class TasksVM
    {
        //Add properties for Title required, Description, Status, Priority
       public int Id { get; set; }
        [Required ]
       
        public string Title { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public int Priority { get; set; }

        public bool IsCompleted { get; set; }

        public string UserId { get; set; }
        public List<Users> Users { get; set; }=new List<Users>();


    }

    public class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
    }
}

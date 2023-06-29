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
      
    }
}

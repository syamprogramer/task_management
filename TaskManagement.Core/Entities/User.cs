using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagement.Core.Entities
{
    //Create class user with properties Id, UserName,password, Email, PhoneNumber,IsActive, CreatedAt, UpdatedAt, DeletedAt
    public class User
    {
        //Create property Id
        //add [Key] attribute   
        [Key]
        public int Id { get; set; }
        //Create property UserName
        public string UserName { get; set; }
        //Create property password
        public string Password { get; set; }
        //Create property Email
        public string Email { get; set; }

        //Create property IsActive
        public bool IsActive { get; set; }
        //Create property CreatedAt
        [Column(TypeName = "datetime2")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
     
        
    }

     
}
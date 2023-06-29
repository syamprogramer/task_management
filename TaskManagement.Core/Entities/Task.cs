using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagement.Core.Entities
{
    //Create class task with properties Id, Title, Description, Status, Priority, CreatedAt, UpdatedAt, DeletedAt
    public class Task
    {
        //Create property Id
        //add [Key] attribute   
        [Key]
        public int Id { get; set; }
        //Create property Title
        public string? Title { get; set; }
        //Create property Description
        public string Description { get; set; }
        //Create property Status
        public int Status { get; set; }
        //Create property Priority
        public int Priority { get; set; }
        //Create property CreatedAt
        [Column(TypeName = "datetime2")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        //Create property UpdatedAt
        [Column(TypeName = "datetime2")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        //Create property DeletedAt
        [Column(TypeName = "datetime2")]
        public DateTime DeletedAt { get; set; } = DateTime.Now;
    }
    
}
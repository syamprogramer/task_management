using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TaskManagement.Data
{
    //Add ApplicationDbContext class with parameter DbContextOptions<ApplicationDbContext> options
    public class ApplicationDbContext : IdentityDbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //Add DbSet for Task
        public DbSet<Core.Entities.Task> Task { get; set; }
    }
}
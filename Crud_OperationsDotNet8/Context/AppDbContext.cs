using Crud_OperationsDotNet8.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_OperationsDotNet8.Context
{
    public class AppDbContext:DbContext
    {
       
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) 
        {
            
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            
           
            base.OnModelCreating(modelBuilder);
        }
    }
}

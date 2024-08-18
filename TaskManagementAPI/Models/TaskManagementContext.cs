
using TaskManagementAPI.Models;
//using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TaskManagementAPI.Models
{
    public class TaskManagementContext : DbContext
    {
        public TaskManagementContext() { }
        public DbSet<TaskManagement> trans { get; set; }
        // public DbSet<Dish> food { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer("server=localhost;initial catalog=foodie;integrated security=true;trustservercertificate=true");
            optionsBuilder.UseSqlServer(@"server=.\sqlexpress;initial catalog=TaskMangementDataBase;user id=Zadmin;password=Pass@123;trustservercertificate=true");
        }
    }
}

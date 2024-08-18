//using EFDemo.Models;
using TransactionAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace TransactionAPI.Models
{
    public class TransactionContext : DbContext
    {
        public TransactionContext() { }
        public DbSet<Transaction> trans { get; set;}
       // public DbSet<Dish> food { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer("server=localhost;initial catalog=foodie;integrated security=true;trustservercertificate=true");
            optionsBuilder.UseSqlServer(@"server=.\sqlexpress;initial catalog=TransationDataBase;user id=sa;password=Pass@123;trustservercertificate=true");
        }

    }
}

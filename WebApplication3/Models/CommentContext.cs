
using Microsoft.EntityFrameworkCore;

namespace EFDemo.Models
{
    public class CommentContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public CommentContext() :base(){ }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
                              //public DbSet<Restaurant> shop { get; set;}
        public DbSet<Comment> trans { get; set; }
       // public object Comments { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer("server=localhost;initial catalog=foodie;integrated security=true;trustservercertificate=true");
            optionsBuilder.UseSqlServer(@"server=.\sqlexpress;initial catalog=CommentDataBase;user id=sa;password=Pass@123;trustservercertificate=true");
        }

        internal object Entry()
        {
            throw new NotImplementedException();
        }
    }
}

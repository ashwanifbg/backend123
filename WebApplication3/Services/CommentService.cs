using EFDemo.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace EFDemo.Services
{
    public class CommentService
    {


        CommentContext context = new CommentContext();
        public void AddComment(Comment r)
        {
            context.trans.Add(r);
            context.SaveChanges();//establish connection and sent sql insert command
        }
        public async Task<List<Comment>> GetAllComment()
        {
            //return context.trans.FromSql($"select * from Transaction").ToList();
            List<Comment> result = null;
            result = await context.trans.ToListAsync();
            return result;
        }
        public Comment GetById(int id)
        {
            return context.trans.Where(s => s.Id == id).FirstOrDefault();
            //
        }
        public bool UpdateComment(int id, Comment r)
        {
            //var result = context.Database.ExecuteSqlRaw($"update restaurants  set name={r.Name},Location={r.Location} where id={r.Id}");
            //or 
            var data = context.trans.Where(s => s.Id == id).FirstOrDefault();
            if (data != null)
            {
                data.Id = r.Id;
                data.TaskId = r.TaskId;
                data.EmployeeId = r.EmployeeId;
                data.CommentText = r.CommentText;
                data.CommentDate = r.CommentDate;


            }
            context.SaveChanges();
            return true;
        }
        public bool DeleteComment(int id)
        {
            // var result = context.Database.ExecuteSql($"delete from restaurants where id={id}");
            //or
            var result = context.trans.Where(s => s.Id == id).FirstOrDefault();
            context.trans.Remove(result);
            context.SaveChanges();
            return true;
        }
    }
}

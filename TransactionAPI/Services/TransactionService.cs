using TransactionAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace TransactionAPI.Services
{
    public class TransactionService
    {


        TransactionContext context = new TransactionContext();
        public void AddTransaction(Transaction r)
        {
            context.trans.Add(r);
            context.SaveChanges();//establish connection and sent sql insert command
        }
        public async Task<List<Transaction>> GetAllTransactions()
        {
             //return context.trans.FromSql($"select * from Transaction").ToList();
            List<Transaction> result = null;
            result = await context.trans.ToListAsync();
            return result;
        }
        public Transaction GetById(int id)
        {
            return context.trans.Where(s => s.TransactionId == id).FirstOrDefault();
            //
        }
        public bool UpdateTransaction(int id, Transaction r)
        {
            //var result = context.Database.ExecuteSqlRaw($"update restaurants  set name={r.Name},Location={r.Location} where id={r.Id}");
            //or 
            var data = context.trans.Where(s => s.TransactionId == id).FirstOrDefault();
            if (data != null)
            {
                data.TransactionId = r.TransactionId;
                data.TaskId = r.TaskId;
                data.Status = r.Status;
                data.Status = r.Status;
               

            }
            context.SaveChanges();
            return true;
        }
        public bool DeleteTransaction(int id)
        {
            // var result = context.Database.ExecuteSql($"delete from restaurants where id={id}");
            //or
            var result = context.trans.Where(s => s.TransactionId == id).FirstOrDefault();
            context.trans.Remove(result);
            context.SaveChanges();
            return true;
        }
    }
}

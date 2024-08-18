using System.ComponentModel.DataAnnotations;


namespace TransactionAPI.Models
{
    public class Transaction
    {
        //[Table("Tranaction")]

        [Key]
        public int TransactionId { get; set; }
        public int TaskId { get; set; }
        public string Status { get; set; }
        public int UpdatedBy { get; set; }
        public string Date { get; set; }


    }
}

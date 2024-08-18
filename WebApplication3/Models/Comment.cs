using System.ComponentModel.DataAnnotations;

namespace EFDemo.Models
{
    public class Comment
    {
       // [Key]
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int EmployeeId { get; set; }
        public string CommentText { get; set; }

        public string CommentDate { get; set; }

    }
}

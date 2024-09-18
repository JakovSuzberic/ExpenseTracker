using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Users
    {
        [Key]
        public int? UserId { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public DateTime? CreatedAt { get; set; }

    }
}

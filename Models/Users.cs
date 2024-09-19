using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Users
    {
        [Key]
        public int? User_Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public DateTime? Created_At { get; set; }

    }
}

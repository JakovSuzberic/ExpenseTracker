using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Expenses: Users
    {
        [Key]
        public int? ExpenseId { get; set; }
        public float? Amount { get; set; }
        public DateTime? Date { get; set; }
        public string? Description { get; set; }

    }
}

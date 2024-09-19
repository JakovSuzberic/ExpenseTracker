using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Expenses: Users
    {
        
        public int? Expense_Id { get; set; }
        public float? Amount { get; set; }
        public DateTime? Date { get; set; }
        public string? Description { get; set; }

    }
}

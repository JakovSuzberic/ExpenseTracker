using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Budgets: Users
    {
        [Key]
        public int? BudgetId { get; set; }
        public float? Amount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }


    }
}

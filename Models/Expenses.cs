using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    /// <summary>Class represents expenses</summary>
    public class Expenses: Users
    {

        /// <summary>Gets or sets the expense identifier.</summary>
        /// <value>The expense identifier.</value>
        public int? Expense_Id { get; set; }

        /// <summary>Gets or sets the amount.</summary>
        /// <value>The amount.</value>
        public float? Amount { get; set; }

        /// <summary>Gets or sets the date.</summary>
        /// <value>The date.</value>
        public DateTime? Date { get; set; }

        /// <summary>Gets or sets the description.</summary>
        /// <value>The description.</value>
        public string? Description { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{

    /// <summary>Class that represents budgets</summary>
    public class Budgets: Users
    {

        /// <summary>Gets or sets the budget identifier.</summary>
        /// <value>The budget identifier.</value>
        public int? Budget_Id { get; set; }

        /// <summary>Gets or sets the amount.</summary>
        /// <value>The amount.</value>
        public float? Amount { get; set; }

        /// <summary>Gets or sets the start date.</summary>
        /// <value>The start date.</value>
        public DateTime? Start_Date { get; set; }

        /// <summary>Gets or sets the end date.</summary>
        /// <value>The end date.</value>
        public DateTime? End_Date { get; set; }


    }
}

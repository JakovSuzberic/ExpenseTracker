using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    
    public class Budgets: Entity
    {
        
        public int? Budget_Id { get; set; }
        public float? Amount { get; set; }
        public DateTime? Start_Date { get; set; }
        public DateTime? End_Date { get; set; }


    }
}

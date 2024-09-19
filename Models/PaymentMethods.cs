using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class PaymentMethods: Users
    {
        
        public int? Payment_Method_Id { get; set; }
        public string? Name { get; set; }


    }
}

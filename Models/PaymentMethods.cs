using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class PaymentMethods: Users
    {
        [Key]
        public int? PaymentMethodId { get; set; }
        public string? Name { get; set; }


    }
}

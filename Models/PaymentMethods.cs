using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    /// <summary>
    ///   <para>Class that represents PaymentMethods</para>
    /// </summary>
    public class PaymentMethods: Users
    {

        /// <summary>Gets or sets the payment method identifier.</summary>
        /// <value>The payment method identifier.</value>
        public int? Payment_Method_Id { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        public string? Name { get; set; }


    }
}

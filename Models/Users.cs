using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{

    /// <summary>
    ///   <para>Class represents User in system</para>
    /// </summary>
    public class Users
    {
        /// <summary>Gets or sets the user identifier.</summary>
        /// <value>The user identifier.</value>
        [Key]
        public int? User_Id { get; set; }

        /// <summary>
        ///   <para>
        /// Gets or sets the name.
        /// </para>
        /// </summary>
        /// <value>The name.</value>
        public string? Name { get; set; }

        /// <summary>Gets or sets the password.</summary>
        /// <value>The password.</value>
        public string? Password { get; set; }

        /// <summary>Gets or sets the email.</summary>
        /// <value>The email.</value>
        public string? Email { get; set; }

        /// <summary>Gets or sets the created at.</summary>
        /// <value>The created at.</value>
        public DateTime? Created_At { get; set; }

    }
}

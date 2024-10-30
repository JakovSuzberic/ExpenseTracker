using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    /// <summary>Class that represents categorys</summary>
    [NotMapped]
    public class Categorys: Users
    {

        /// <summary>Gets or sets the category identifier.</summary>
        /// <value>The category identifier.</value>
        public int? Category_Id { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        public string? Name { get; set; }

        /// <summary>Gets or sets the description.</summary>
        /// <value>The description.</value>
        public string? Description { get; set; }

    }
}

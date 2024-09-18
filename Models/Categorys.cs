using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Categorys: Users
    {
        [Key]
        public int? CategoryId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

    }
}

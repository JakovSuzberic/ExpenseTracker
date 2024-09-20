using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    [NotMapped]
    public class Categorys: Users
    {
        
        public int? Category_Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

    }
}

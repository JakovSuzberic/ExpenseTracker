using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Categorys: Users
    {
        
        public int? Category_Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

    }
}

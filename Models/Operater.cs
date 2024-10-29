using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class Operater: Entity
    {

        public string? Email { get; set; }
        [Column("Passwordd")]
        public string? Password { get; set; }

    }
}

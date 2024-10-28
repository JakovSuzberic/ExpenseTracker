using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public abstract class Entity
    {

            [Key]
            public int? Entity_id { get; set; }

    }
}

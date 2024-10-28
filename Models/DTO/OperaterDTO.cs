using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models.DTO
{
    public record OperaterDTO
    (

        [Required(ErrorMessage ="Email is required")]
        string? email,

        [Required(ErrorMessage ="Password is required")]
        string? password

    );
}

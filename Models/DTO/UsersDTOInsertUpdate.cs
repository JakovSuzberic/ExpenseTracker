using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models.DTO
{
    public record UsersDTOInsertUpdate
    (

        [Required(ErrorMessage = "Name is required")]
        string Name,

        [Required(ErrorMessage = "Password i required")]
        string Password,

        string Email,

        [Required(ErrorMessage = "Created at date is required")]
        DateTime Created_at

    );
}

     
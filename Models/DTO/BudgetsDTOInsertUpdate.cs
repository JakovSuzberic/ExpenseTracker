using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models.DTO
{
    public record BudgetsDTOInsertUpdate
    (

        [Required(ErrorMessage ="Budget Id is required")]
        int? budget_id,
        [Required(ErrorMessage ="Amount is required")]
        float amount,
        [Required(ErrorMessage ="Start date is required")]
        DateTime start_date,
        DateTime end_date

        
    );
    
}

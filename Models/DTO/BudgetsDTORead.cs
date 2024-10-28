namespace ExpenseTracker.Models.DTO
{
    public record BudgetsDTORead
    (

           int budget_id,
           float amount,
           DateTime start_date,
           DateTime end_date

    );
}

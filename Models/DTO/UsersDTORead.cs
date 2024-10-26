namespace ExpenseTracker.Models.DTO
{
        public record UsersDTORead(

            int User_id,
            string? Name,
            string? Password,
            string? Email,
            DateTime? Created_At
           
        );

}
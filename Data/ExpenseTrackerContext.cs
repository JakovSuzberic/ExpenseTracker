using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Data
{
    public class ExpenseTrackerContext : DbContext
    {

        public ExpenseTrackerContext(DbContextOptions<ExpenseTrackerContext> options) : base(options) 
        { 
            
            
            
        }

        public DbSet<Users> Users { get; set; }
        //public DbSet<Budgets> Budgets { get; set; }
        //public DbSet<Categorys> Categorys { get; set; }
        //public DbSet<Expenses> Expenses { get; set; }
        //public DbSet<PaymentMethods> PaymentMethods { get; set; }



    }
}

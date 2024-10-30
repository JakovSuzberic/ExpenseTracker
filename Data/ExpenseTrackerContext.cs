using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Data
{

    public class ExpenseTrackerContext : DbContext
    {

        /// <summary>Database context for the ExpenseTracker application.</summary>
        /// <remarks>Constructor that accepts options for configuring the context.</remarks>
        /// <param name="options">Options for configuration the context.</param>
        public ExpenseTrackerContext(DbContextOptions<ExpenseTrackerContext> options) : base(options) 
        { 
            
            
            
        }

        /// <summary>Collection of date for entity Users</summary>
        /// <value>The users.</value>
        public DbSet<Users> Users { get; set; }
        //public DbSet<Budgets> Budgets { get; set; }
        //public DbSet<Categorys> Categorys { get; set; }
        //public DbSet<Expenses> Expenses { get; set; }
        //public DbSet<PaymentMethods> PaymentMethods { get; set; }


    }
}

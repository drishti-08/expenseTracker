using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Transaction> Transactions { get; set; }  //the name of the transaction table is transactions
        public DbSet<Category> Categories { get; set; } // same as above
    }
}

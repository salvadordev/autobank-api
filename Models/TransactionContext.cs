using Microsoft.EntityFrameworkCore;

namespace AutoBank.Models
{
  public class TransactionContext : DbContext
  {
    public TransactionContext(DbContextOptions<TransactionContext> options) : base(options) { }

    public DbSet<Transaction> Transactions { get; set; }
    
  }
}
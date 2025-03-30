using Microsoft.EntityFrameworkCore;

namespace SpentSmart.Models
{
    public class SpendSmartDbContext : DbContext
    {
        public SpendSmartDbContext(DbContextOptions<SpendSmartDbContext> options) : base(options) { }

        public DbSet<Expense> Expenses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expense>()
                .Property(e => e.Value)
                .HasColumnType("decimal(18,2)"); // Allows up to 18 digits with 2 decimal places
        }
    }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BudgetAppWeb.Domain.Models;

namespace BudgetAppWeb.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Fund> Funds { get; set; }
        public DbSet<HomeBudget> HomeBudgets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=BudgetAppWebTEST;User Id=sa;Password=;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>()
                .HasKey(b => b.Id);

            modelBuilder.Entity<Expense>()
                .HasKey(b => b.Id);

            modelBuilder.Entity<Fund>()
                .HasKey(b => b.Id);

            
            modelBuilder.Entity<Expense>()
                .HasOne(e => e.Client)
                .WithMany(c => c.Expenses)
                .HasForeignKey(e => e.ExpenseForeignKey);

            
            modelBuilder.Entity<Client>()
                .HasOne(c => c.Fund)
                .WithOne(f => f.Client)
                .HasForeignKey<Fund>(f => f.FundForeignKey);

            modelBuilder.Entity<HomeBudget>()
                .HasOne(hb => hb.Client)
                .WithMany(c => c.HomeBudgets)
                .HasForeignKey(hb => hb.HomeBudgetForeignKey);
        }
    }
}
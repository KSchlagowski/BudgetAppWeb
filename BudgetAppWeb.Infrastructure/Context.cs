//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
//using System.Linq;
using BudgetAppWeb.Domain.Models;

namespace BudgetAppWeb.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Fund> Funds { get; set; }
        public DbSet<HomeBudget> HomeBudgets { get; set; }
        public DbSet<User> Users { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //one2one
            // builder.Entity<User>()
            //     .HasOne(a => a.Fund).WithOne(b => b.User);
                //.HasForeignKey<UserContactInformation>(e => e.UserRef)

            // builder.Entity<Expense>
            //     .HasKey(it => new { it.Id, it.ExpenseId});

            // //many2many
            // builder.Entity<Expense>()
            //     .HasOne<User>(it => it.User)
            //     .WithMany(i => i.Expenses)
            //     .HasForeignKey(it => it.ExpenseId);
        }
    }
}
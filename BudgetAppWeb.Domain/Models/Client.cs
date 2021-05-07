using System.Collections.Generic;

namespace BudgetAppWeb.Domain.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Expense> Expenses { get; set; }
        public virtual Fund Fund { get; set; }
        public ICollection<HomeBudget> HomeBudgets { get; set; }
    }
}
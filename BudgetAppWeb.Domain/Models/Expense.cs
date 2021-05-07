using System;

namespace BudgetAppWeb.Domain.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        public string Description { get; set; }
        public DateTime ExpenseDate { get; set; } = DateTime.Now;
        public string Category { get; set; }

        public int ExpenseForeignKey { get; set; }
        public Client Client { get; set; }
    }
}
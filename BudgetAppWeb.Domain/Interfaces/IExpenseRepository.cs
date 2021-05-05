using BudgetAppWeb.Domain.Models;

namespace BudgetAppWeb.Domain.Interfaces
{
    public interface IExpenseRepository
    {
        void DeleteExpense(int expenseId);
        int AddExpense(Expense expense);
        Expense GetExpenseById(int expenseId);
    }
}
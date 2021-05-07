using BudgetAppWeb.Infrastructure;
using BudgetAppWeb.Domain.Interfaces;
using BudgetAppWeb.Domain.Models;
using System.Linq;


namespace BudgetAppWeb.Infrastructure.Repositories
{
    public class ExpenseRepository
    {
        // private readonly Context _context;
        // public ExpenseRepository(Context context)
        // {
        //     _context = context;
        // }

        // public void DeleteExpense(int expenseId)
        // {
        //     var expense = _context.Expenses.Find(expenseId);
        //     if (expenseId != null)
        //     {
        //         _context.Expenses.Remove(expense);
        //         _context.SaveChanges();
        //     }
        // }

        // public int AddExpense(Expense expense)
        // {
        //     _context.Expenses.Add(expense);
        //     _context.SaveChanges();

        //     return expense.Id;
        // }

        // // public IQueryable<Expense> GetExpensesByTypeId(int typeId)
        // // {
        // //     var expenses = _context.Expenses.Where(i => i.Id == typeId);
            
        // //     return expenses;
        // // }

        // public Expense GetExpenseById(int expenseId)
        // {
        //     var expense = _context.Expenses.FirstOrDefault(i => i.Id == expenseId);

        //     return expense;
        // }
    }
}
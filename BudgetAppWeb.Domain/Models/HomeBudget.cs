namespace BudgetAppWeb.Domain.Models
{
    public class HomeBudget
    {
        public int Id { get; set; }
        public string Month { get; set; }
        public decimal Earnings { get; set; }
        public decimal FixedExpenses { get; set; }
        public decimal VariableExpenses { get; set; }
        public decimal IrregularExpenses { get; set; }
        public decimal Balance { get; set; }
        public decimal FinalBalance { get; set; }
    }
}
namespace BudgetAppWeb.Domain.Models
{
    public class Fund
    {
        public int Id { get; set; }
        public decimal IrregularExpensesFundBalance{ get; set; } = 0;
        public decimal EmergencyFundBalance { get; set; } = 0;
        public decimal SecurityFundBalance { get; set; } = 0;
        public decimal SpecialPurposeFundBalance { get; set; } = 0;

        public virtual User User { get; set; }
    }
}
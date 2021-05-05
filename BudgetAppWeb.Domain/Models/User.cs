using System.Collections.Generic;

namespace BudgetAppWeb.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual Fund Fund { get; set; }
    }
}
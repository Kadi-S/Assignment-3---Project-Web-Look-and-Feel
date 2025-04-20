using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinanceHub.Models
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionID { get; set; }

        public int UserID { get; set; } // FK
        public string Type { get; set; } // "Income" or "Expense"
        public string Category { get; set; } // e.g., Food, Salary, Rent
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        // Navigation
        public User User { get; set; }
    }
}

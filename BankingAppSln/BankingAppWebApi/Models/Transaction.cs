using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingAppWebApi.Models
{
    public class Transaction
    {

        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public string TransactionId { get; set; }

        public DateTime TransactionDate { get; set; }

        public string TransactionTypeId { get; set; }
        public string Description { get; set; }

        public string Reference { get; set; }

        public decimal Amount { get; set; }

        [ForeignKey("BankAccount")]

        public int BankAccountId { get; set; }

        public BankAccount? BankAccount { get; set; }
    }
}

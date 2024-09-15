using HomeAccounting.Domain.Common;

namespace HomeAccounting.Domain.Entities
{
    public class Transaction : Entity
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Comment { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

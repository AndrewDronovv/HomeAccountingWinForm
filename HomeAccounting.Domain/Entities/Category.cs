using HomeAccounting.Domain.Common;

namespace HomeAccounting.Domain.Entities
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public bool IsIncome { get; set; }

        public Category(string name, bool isIncome)
        {
            Name = name;
            IsIncome = isIncome;
        }
    }
}

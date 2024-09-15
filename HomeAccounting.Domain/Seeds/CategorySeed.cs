using HomeAccounting.Domain.Entities;

namespace HomeAccounting.Domain.Seeds
{
    public class CategorySeed : BaseSeed
    {
        public CategorySeed(AppDbContext context) : base(context)
        {
        }

        public override void Seed()
        {
            var incomeCategories = new string[]
            {
                "Заработная плата", "Аренда недвижимости", "Иные расходы"
            };
            
            var expenditureCategories = new string[]
            {
                "Продукты питания", "Транспорт", "Мобильная связь", "Интернет", "Развлечения", "Другое"
            };
            
            AddCategories(incomeCategories, true);
            AddCategories(expenditureCategories, false);

            Context.SaveChanges();
        }

        private void AddCategories(IEnumerable<string> categoryNames, bool isIncome)
        {
            foreach (var categoryName in categoryNames)
            {
                var category = Context.Categories.FirstOrDefault(i => i.Name == categoryName);
                if (category == null)
                {
                    Context.Categories.Add(new Category(categoryName, isIncome));
                }
            }
        }
    }
}
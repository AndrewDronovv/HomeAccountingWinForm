namespace HomeAccounting.Domain.Seeds
{
    public static class AppDbContextInitializer
    {
        public static void Seed(AppDbContext context)
        {
            new CategorySeed(context).Seed();
        }
    }
}

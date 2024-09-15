using HomeAccounting.Domain;
using HomeAccounting.Domain.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StoreWinFrom;
using StoreWinFrom.Forms;

namespace HomeAccountingWinForm
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.SetBasePath(Directory.GetCurrentDirectory());
                    config.AddJsonFile("appsettings.json");
                })
                .ConfigureServices((context, services) =>
                {
                    var connectionString = context.Configuration.GetConnectionString("Default");
                    services.AddDbContext<AppDbContext>(opt => opt.UseNpgsql(connectionString));

                    services.AddTransient<MainForm>();
                    services.AddTransient<LoginForm>();
                    services.AddTransient<RegisterForm>();
                    services.AddTransient<StatisticForm>();
                });

            var host = builder.Build();
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                var context = services.GetService<AppDbContext>();
                AppDbContextInitializer.Seed(context);

                ApplicationConfiguration.Initialize();
                Application.Run(services.GetService<LoginForm>());
            }
        }
    }
}
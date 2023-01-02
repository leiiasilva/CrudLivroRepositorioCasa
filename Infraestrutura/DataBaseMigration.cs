using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestrutura
{
    public static class DataBaseMigration
    {
        public static void RunMigrations()
        {
            var serviceProvider = CreateService();
            using (var scope = serviceProvider.CreateScope())
            {
                RunMigrations(scope.ServiceProvider);
            }
        }


        private static IServiceProvider CreateService()
        {
            return new ServiceCollection()
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddSqlServer()
                    .WithGlobalConnectionString(ConnectionString)
                    .ScanIn(typeof(DataBaseMigration).Assembly).For.Migrations())
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                .BuildServiceProvider(false);
        }

        private static void RunMigrations(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();

            runner.MigrateUp();
        }

        private const string ConnectionString = "Data Source=DESKTOP-7J8QTFJ;Initial Catalog=CrudLivros;User ID=sa;Password=1234";
    }
}

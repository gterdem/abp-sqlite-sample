using System.IO;
using Microsoft.Extensions.DependencyInjection;
using AbpIoSqliteSample.Data;
using Serilog;
using Serilog.Events;
using Volo.Abp;
using Volo.Abp.Threading;

namespace AbpIoSqliteSample.DbMigrator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigureLogging();

            using (var application = AbpApplicationFactory.Create<AbpIoSqliteSampleDbMigratorModule>(options =>
            {
                options.UseAutofac();
                options.Services.AddLogging(c => c.AddSerilog());
            }))
            {
                application.Initialize();

                AsyncHelper.RunSync(
                    () => application
                        .ServiceProvider
                        .GetRequiredService<AbpIoSqliteSampleDbMigrationService>()
                        .MigrateAsync()
                );

                application.Shutdown();
            }
        }

        private static void ConfigureLogging()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .MinimumLevel.Override("Volo.Abp", LogEventLevel.Warning)
#if DEBUG
                .MinimumLevel.Override("AbpIoSqliteSample", LogEventLevel.Debug)
#else
                .MinimumLevel.Override("AbpIoSqliteSample", LogEventLevel.Information)
#endif
                .Enrich.FromLogContext()
                .WriteTo.File(Path.Combine(Directory.GetCurrentDirectory(), "Logs/logs.txt"))
                .WriteTo.Console()
                .CreateLogger();
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AbpIoSqliteSample.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpIoSqliteSampleEntityFrameworkCoreModule)
        )]
    public class AbpIoSqliteSampleEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpIoSqliteSampleMigrationsDbContext>();
        }
    }
}

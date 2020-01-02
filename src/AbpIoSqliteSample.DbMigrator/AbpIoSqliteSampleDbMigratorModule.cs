using AbpIoSqliteSample.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpIoSqliteSample.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpIoSqliteSampleEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpIoSqliteSampleApplicationContractsModule)
        )]
    public class AbpIoSqliteSampleDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}

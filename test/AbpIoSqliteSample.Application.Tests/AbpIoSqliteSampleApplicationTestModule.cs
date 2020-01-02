using Volo.Abp.Modularity;

namespace AbpIoSqliteSample
{
    [DependsOn(
        typeof(AbpIoSqliteSampleApplicationModule),
        typeof(AbpIoSqliteSampleDomainTestModule)
        )]
    public class AbpIoSqliteSampleApplicationTestModule : AbpModule
    {

    }
}
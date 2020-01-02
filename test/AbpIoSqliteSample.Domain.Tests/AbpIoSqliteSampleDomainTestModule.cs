using AbpIoSqliteSample.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpIoSqliteSample
{
    [DependsOn(
        typeof(AbpIoSqliteSampleEntityFrameworkCoreTestModule)
        )]
    public class AbpIoSqliteSampleDomainTestModule : AbpModule
    {

    }
}
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AbpIoSqliteSample.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(AbpIoSqliteSampleHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AbpIoSqliteSampleConsoleApiClientModule : AbpModule
    {
        
    }
}

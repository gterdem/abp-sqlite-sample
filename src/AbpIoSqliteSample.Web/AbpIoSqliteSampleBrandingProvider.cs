using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace AbpIoSqliteSample.Web
{
    [Dependency(ReplaceServices = true)]
    public class AbpIoSqliteSampleBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpIoSqliteSample";
    }
}

using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using AbpIoSqliteSample.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpIoSqliteSample.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits AbpIoSqliteSample.Web.Pages.AbpIoSqliteSamplePage
     */
    public abstract class AbpIoSqliteSamplePage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<AbpIoSqliteSampleResource> L { get; set; }
    }
}

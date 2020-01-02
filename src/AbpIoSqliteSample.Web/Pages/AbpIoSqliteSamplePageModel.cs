using AbpIoSqliteSample.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpIoSqliteSample.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AbpIoSqliteSamplePageModel : AbpPageModel
    {
        protected AbpIoSqliteSamplePageModel()
        {
            LocalizationResourceType = typeof(AbpIoSqliteSampleResource);
        }
    }
}
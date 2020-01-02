using AbpIoSqliteSample.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpIoSqliteSample.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpIoSqliteSampleController : AbpController
    {
        protected AbpIoSqliteSampleController()
        {
            LocalizationResource = typeof(AbpIoSqliteSampleResource);
        }
    }
}
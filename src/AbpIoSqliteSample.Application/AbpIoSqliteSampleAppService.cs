using System;
using System.Collections.Generic;
using System.Text;
using AbpIoSqliteSample.Localization;
using Volo.Abp.Application.Services;

namespace AbpIoSqliteSample
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpIoSqliteSampleAppService : ApplicationService
    {
        protected AbpIoSqliteSampleAppService()
        {
            LocalizationResource = typeof(AbpIoSqliteSampleResource);
        }
    }
}

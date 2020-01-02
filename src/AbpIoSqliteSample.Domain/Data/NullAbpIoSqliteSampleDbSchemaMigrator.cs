using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpIoSqliteSample.Data
{
    /* This is used if database provider does't define
     * IAbpIoSqliteSampleDbSchemaMigrator implementation.
     */
    public class NullAbpIoSqliteSampleDbSchemaMigrator : IAbpIoSqliteSampleDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}
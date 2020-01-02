using System.Threading.Tasks;

namespace AbpIoSqliteSample.Data
{
    public interface IAbpIoSqliteSampleDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}

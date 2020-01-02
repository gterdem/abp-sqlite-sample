using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AbpIoSqliteSample.Data;
using Volo.Abp.DependencyInjection;

namespace AbpIoSqliteSample.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreAbpIoSqliteSampleDbSchemaMigrator 
        : IAbpIoSqliteSampleDbSchemaMigrator, ITransientDependency
    {
        private readonly AbpIoSqliteSampleMigrationsDbContext _dbContext;

        public EntityFrameworkCoreAbpIoSqliteSampleDbSchemaMigrator(AbpIoSqliteSampleMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}
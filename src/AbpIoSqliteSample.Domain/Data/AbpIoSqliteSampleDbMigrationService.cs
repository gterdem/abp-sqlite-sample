﻿using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace AbpIoSqliteSample.Data
{
    public class AbpIoSqliteSampleDbMigrationService : ITransientDependency
    {
        public ILogger<AbpIoSqliteSampleDbMigrationService> Logger { get; set; }

        private readonly IDataSeeder _dataSeeder;
        private readonly IAbpIoSqliteSampleDbSchemaMigrator _dbSchemaMigrator;

        public AbpIoSqliteSampleDbMigrationService(
            IDataSeeder dataSeeder,
            IAbpIoSqliteSampleDbSchemaMigrator dbSchemaMigrator)
        {
            _dataSeeder = dataSeeder;
            _dbSchemaMigrator = dbSchemaMigrator;

            Logger = NullLogger<AbpIoSqliteSampleDbMigrationService>.Instance;
        }

        public async Task MigrateAsync()
        {
            Logger.LogInformation("Started database migrations...");

            Logger.LogInformation("Migrating database schema...");
            await _dbSchemaMigrator.MigrateAsync();

            Logger.LogInformation("Executing database seed...");
            await _dataSeeder.SeedAsync();

            Logger.LogInformation("Successfully completed database migrations.");
        }
    }
}
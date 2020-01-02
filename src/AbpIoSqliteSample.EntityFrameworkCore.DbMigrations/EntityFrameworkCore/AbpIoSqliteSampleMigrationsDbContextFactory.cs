﻿using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpIoSqliteSample.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class AbpIoSqliteSampleMigrationsDbContextFactory : IDesignTimeDbContextFactory<AbpIoSqliteSampleMigrationsDbContext>
    {
        public AbpIoSqliteSampleMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AbpIoSqliteSampleMigrationsDbContext>()
                .UseSqlite(configuration.GetConnectionString("Default"));

            return new AbpIoSqliteSampleMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}

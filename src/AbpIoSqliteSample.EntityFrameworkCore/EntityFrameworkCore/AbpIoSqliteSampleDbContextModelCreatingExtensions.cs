using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp;
using Volo.Abp.Users;

namespace AbpIoSqliteSample.EntityFrameworkCore
{
    public static class AbpIoSqliteSampleDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpIoSqliteSample(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AbpIoSqliteSampleConsts.DbTablePrefix + "YourEntities", AbpIoSqliteSampleConsts.DbSchema);

            //    //...
            //});
        }

        public static void ConfigureCustomUserProperties<TUser>(this EntityTypeBuilder<TUser> b)
            where TUser: class, IUser
        {
            //b.Property<string>(nameof(AppUser.MyProperty))...
        }
    }
}
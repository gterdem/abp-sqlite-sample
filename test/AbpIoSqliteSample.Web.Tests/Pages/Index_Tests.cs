using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AbpIoSqliteSample.Pages
{
    public class Index_Tests : AbpIoSqliteSampleWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}

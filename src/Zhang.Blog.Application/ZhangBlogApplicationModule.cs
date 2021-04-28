
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Zhang.Blog
{
    [DependsOn(
        typeof(AbpIdentityApplicationModule)
        )]
    public class ZhangBlogApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
     
        }
    }
}

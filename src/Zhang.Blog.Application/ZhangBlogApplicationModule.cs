
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

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


using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace Zhang.Blog.HttpApi
{
    [DependsOn(

        typeof(AbpIdentityHttpApiModule),
        typeof(ZhangBlogApplicationModule)
        )]
    public class ZhangBlogHttpApiModule : AbpModule
    {
       
    }
}

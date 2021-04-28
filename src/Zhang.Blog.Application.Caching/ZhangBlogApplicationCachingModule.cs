using Volo.Abp.Caching;
using Volo.Abp.Modularity;
using Zhang.Blog.Domain;

namespace Zhang.Blog.Application.Caching
{
    [DependsOn(typeof(AbpCachingModule)
        , typeof(ZhangBlogDomainModule))
        ]
    public class ZhangBlogApplicationCachingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
        }
    }
}

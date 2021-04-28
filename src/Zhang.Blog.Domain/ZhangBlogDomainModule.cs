

using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Zhang.Blog.Domain
{
    [DependsOn(
          typeof(AbpIdentityDomainModule)
    )]
    public class ZhangBlogDomainModule : AbpModule
    {
       
    }
}

using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Zhang.Blog.Domain.Blog;
using Zhang.Blog.Domain.Repositories;

namespace Zhang.Blog.EntityFrameworkCore.Repositories.Blog
{
    /// <summary>
    /// FriendLinkRepository
    /// </summary>
    public class FriendLinkRepository : EfCoreRepository<ZhangBlogDbContext, FriendLink, int>, IFriendLinkRepository
    {
        public FriendLinkRepository(IDbContextProvider<ZhangBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
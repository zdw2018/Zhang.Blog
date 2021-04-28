using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Zhang.Blog.Domain.Blog;
using Zhang.Blog.Domain.Repositories;

namespace Zhang.Blog.EntityFrameworkCore.Repositories.Blog
{
    /// <summary>
    /// PostRepository
    /// </summary>
    public class PostRepository : EfCoreRepository<ZhangBlogDbContext, Post, int>, IPostRepository
    {
        public PostRepository(IDbContextProvider<ZhangBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
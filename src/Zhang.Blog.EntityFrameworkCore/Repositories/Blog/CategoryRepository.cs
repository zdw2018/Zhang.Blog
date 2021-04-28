using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Zhang.Blog.Domain.Blog;
using Zhang.Blog.Domain.Repositories;

namespace Zhang.Blog.EntityFrameworkCore.Repositories.Blog
{
    /// <summary>
    /// CategoryRepository
    /// </summary>
    public class CategoryRepository : EfCoreRepository<ZhangBlogDbContext, Category, int>, ICategoryRepository
    {
        public CategoryRepository(IDbContextProvider<ZhangBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
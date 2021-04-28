using Volo.Abp.Domain.Repositories;
using Zhang.Blog.Domain.Blog;

namespace Zhang.Blog.Domain.Repositories
{
    /// <summary>
    /// ICategoryRepository
    /// </summary>
    public interface ICategoryRepository : IRepository<Category, int>
    {

    }
}
using Volo.Abp.Domain.Repositories;

using Zhang.Blog.Domain.Blog;

namespace Zhang.Blog.Domain.Repositories
{
    /// <summary>
    /// IPostRepository
    /// </summary>
    public interface IPostRepository : IRepository<Post, int>
    {

    }
}
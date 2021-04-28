using System.Threading.Tasks;
using Zhang.Blog.Application.Contracts.Blog;
using Zhang.Blog.ToolKits.Base;

namespace Zhang.Blog.Application.Blog
{
    public interface IBlogService
    {
        //Task<bool> InsertPostAsync(PostDto dto);
         Task<ServiceResult<string>> InsertPostAsync(PostDto dto);

        //Task<bool> DeletePostAsync(int id);
         Task<ServiceResult> DeletePostAsync(int id);

        //Task<bool> UpdatePostAsync(int id, PostDto dto);
         Task<ServiceResult<string>> UpdatePostAsync(int id, PostDto dto);

        //Task<PostDto> GetPostAsync(int id);
         Task<ServiceResult<PostDto>> GetPostAsync(int id);
    }
}

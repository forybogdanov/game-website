using GameWebsite.Service.Models.Posts;

namespace GameWebsite.Services.Posts
{
    public interface IPostService
    {
        Task<PostDto> CreatePost(PostDto postDto);
        Task<PostDto> DeletePost(long id);
        IQueryable<PostDto> GetAllPosts();
        Task<PostDto> GetPostById(long id);
        Task<PostDto> UpdatePost(long id, PostDto postDto);
    }
}

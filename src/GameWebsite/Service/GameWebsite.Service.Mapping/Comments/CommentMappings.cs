using GameWebsite.Data.Models;
using GameWebsite.Service.Models.Comments;

namespace GameWebsite.Service.Mapping.Comments
{
    public static class CommentMappings
    {
        public static Comment ToEntity(this CommentDto commentDto)
        {
            return new Comment
            {
                Id = commentDto.Id,
                CreatedAt = commentDto.CreatedAt,
                Content = commentDto.Content,
            };
        }
        public static CommentDto ToDto(this Comment comment)
        {
            return new CommentDto
            {
                Id = comment.Id,
                CreatedAt = comment.CreatedAt,
                Content = comment.Content,
            };
        }
    }
}

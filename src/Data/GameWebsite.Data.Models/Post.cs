
namespace GameWebsite.Data.Models
{
    public class Post : BaseEntity
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

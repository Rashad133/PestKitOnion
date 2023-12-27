using PestKitOnion.Domain.Entities.Common;

namespace PestKitOnion.Domain.Entities
{
    public class Blog:BaseNameableEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime DateTime { get; set; }
        public int AuthorId { get; set; }
        public int CommentCount { get; set; }
        public Author? Author { get; set; }
        public ICollection<BlogTag>? Tags { get; set; }
    }
}

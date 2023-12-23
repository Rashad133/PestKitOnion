using PestKitOnion.Domain.Entities.Common;

namespace PestKitOnion.Domain.Entities
{
    public class Author:BaseNameableEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Blog>? Blogs { get; set; }
    }
}

namespace PestKitOnion.Application.DTOs.Blog;

public record BlogCreateDto(string Title,string Name, string Description, int CommentCount, int AuthorId, ICollection<int> Tagids);

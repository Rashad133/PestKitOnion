namespace PestKitOnion.Application.DTOs.Blog;

public record BlogUpdateDto(string Title, string Description, int CommentCount, int AuthorId, ICollection<int> TagIds);
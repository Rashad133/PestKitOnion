using PestKitOnion.Application.DTOs.Author;

namespace PestKitOnion.Application.DTOs.Blog;

public record BlogItemDto
{
    //(int Id, string Title, string Description, int ReplyCount, int AuthorId, IncludeAuthorDto Author)

    public int Id { get; init; }
    public string Title { get; init; }
    public string Description { get; init; }
    public int ReplyCount { get; init; }
    public int AuthorId { get; init; }
    public IncludeAuthorDto Author { get; init; }
}

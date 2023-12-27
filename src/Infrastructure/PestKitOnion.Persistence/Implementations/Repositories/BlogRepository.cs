using PestKitOnion.Application.Abstractions.Repositories;
using PestKitOnion.Domain.Entities;
using PestKitOnion.Persistence.Contexts;
using PestKitOnion.Persistence.Implementations.Repositories.Generics;

namespace PestKitOnion.Persistence.Implementations.Repositories
{
    public class BlogRepository : Repository<Blog>, IBlogRepository
    {
        public BlogRepository(AppDbContext db) : base(db)
        {

        }
    }
}

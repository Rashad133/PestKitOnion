using PestKitOnion.Application.Abstractions.Repositories;
using PestKitOnion.Domain.Entities;
using PestKitOnion.Persistence.Contexts;
using PestKitOnion.Persistence.Implementations.Repositories.Generics;

namespace PestKitOnion.Persistence.Implementations.Repositories
{
    internal class AuthorRepository:Repository<Author>,IAuthorRepository
    {
        public AuthorRepository(AppDbContext db):base(db)
        {
            
        }
    }
}

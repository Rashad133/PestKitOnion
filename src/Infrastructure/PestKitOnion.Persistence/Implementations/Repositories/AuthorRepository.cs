using PestKitOnion.Application.Abstractions.Repositories;
using PestKitOnion.Domain.Entities;
using PestKitOnion.Persistence.Contexts;
using PestKitOnion.Persistence.Implementations.Repositories.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PestKitOnion.Persistence.Implementations.Repositories
{
    internal class AuthorRepository:Repository<Author>,IAuthorRepository
    {
        public AuthorRepository(AppDbContext db):base(db)
        {
            
        }
    }
}

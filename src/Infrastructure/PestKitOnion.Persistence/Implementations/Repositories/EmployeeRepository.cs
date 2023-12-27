using PestKitOnion.Application.Abstractions.Repositories;
using PestKitOnion.Domain.Entities;
using PestKitOnion.Persistence.Contexts;
using PestKitOnion.Persistence.Implementations.Repositories.Generics;

namespace PestKitOnion.Persistence.Implementations.Repositories
{
    internal class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext db) : base(db)
        {

        }
    }
}

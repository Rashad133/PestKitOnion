using PestKitOnion.Application.Abstractions.Repositories.Generics;
using PestKitOnion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PestKitOnion.Application.Abstractions.Repositories
{
    public interface IBlogRepository:IRepository<Blog>
    {
    }
}

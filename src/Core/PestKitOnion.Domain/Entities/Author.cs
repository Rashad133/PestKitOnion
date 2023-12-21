using PestKitOnion.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PestKitOnion.Domain.Entities
{
    public class Author:BaseNameableEntity
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public ICollection<Blog>? Blogs { get; set; }
    }
}

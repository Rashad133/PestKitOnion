using PestKitOnion.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PestKitOnion.Domain.Entities
{
    public class BlogTag:BaseNameableEntity
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public int TagId { get; set; }
        public Blog Blog { get; set; }
        public Tag Tag { get; set; }
    }
}

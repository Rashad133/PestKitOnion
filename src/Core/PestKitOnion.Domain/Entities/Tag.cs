using PestKitOnion.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PestKitOnion.Domain.Entities
{
    public class Tag:BaseNameableEntity
    {
        public int Id { get; set; }
        public ICollection<BlogTag>? BlogTags { get; set; }
    }
}
    
using PestKitOnion.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PestKitOnion.Domain.Entities
{
    public class Position:BaseNameableEntity
    {
        public int Id { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}

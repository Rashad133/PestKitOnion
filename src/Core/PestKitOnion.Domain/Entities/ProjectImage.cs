using PestKitOnion.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PestKitOnion.Domain.Entities
{
    public class ProjectImage:BaseNameableEntity
    {
        public int Id { get; set; }
        public bool? IsPrimary { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}

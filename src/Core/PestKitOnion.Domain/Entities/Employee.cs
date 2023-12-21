using PestKitOnion.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PestKitOnion.Domain.Entities
{
    public class Employee:BaseNameableEntity
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public int DepartmentId { get; set; }
        public int PositionId { get; set; }
        public string? InstLink { get; set; }
        public string? TwitLink { get; set; }
        public string? FaceLink { get; set; }
        public string? LinkedLink { get; set; }
        public Department Department { get; set; }
        public Position Position { get; set; }
    }
}

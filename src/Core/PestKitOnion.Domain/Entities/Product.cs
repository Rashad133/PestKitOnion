using PestKitOnion.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PestKitOnion.Domain.Entities
{
    public class Product:BaseNameableEntity
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}

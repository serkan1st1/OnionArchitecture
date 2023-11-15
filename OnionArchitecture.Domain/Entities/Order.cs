using OnionArchitecture.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Domain.Entities
{
    public sealed class Order : BaseEntity
    {
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public string CompId { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}

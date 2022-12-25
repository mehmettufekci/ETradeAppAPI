using ETradeAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeAPI.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        // Bir order ın birden fazla product ı olduğunu ifade ediyor
        public ICollection<Product> Products { get; set; }
        // Bir order ın sadece bir customer ı olabilir
        public Customer Customer { get; set; }
    }
}

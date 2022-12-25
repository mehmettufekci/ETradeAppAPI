using ETradeAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeAPI.Domain.Entities
{
    public class Customer:BaseEntity
    {
        public string Name  { get; set; }
        // Bir customer ın birden fazla order ı olabilir
        public ICollection<Order> Orders { get; set; }
    }
}

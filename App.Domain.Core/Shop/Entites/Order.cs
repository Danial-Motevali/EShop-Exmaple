using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Shop.Entites
{
    public class Order
    {
        public int? Id { get; set; }

        public int? CustomerId { get; set; }

        public DateTime OrderAt { get; set; }

        public ICollection<OrderLine> OrderLines { get; set; } = new List<OrderLine>();

        public int? OrderStatusId { get; set; }

        public OrderStatus OrderStatus { get; set; } = null;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Shop.Entites
{
    public class OrderLine
    {
        public int? Id { get; set; }

        public int? Qty { get; set; }

        public int? ProductPriceId { get; set; }

        public int? OrderId { get; set; }

        public Order Order { get; set; } = null;

        public int? ProductId { get; set; }

        public Product Product { get; set; } = null;
    }
}

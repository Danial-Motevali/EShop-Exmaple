using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Shop.Entites
{
    public class ProductPrice
    {
        public int Id { get; set; }

        public int? ProductId { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public int? Price { get; set; }

        public virtual Product? Product { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Shop.Entites
{
    public class Product
    {
        public int? Id { get; set; }

        public string Title { get; set; } = null;

        public int? CalculatedQty { get; set; } = null;

        public bool IsRemoved { get; set; }

        public Category Category { get; set; } = null;

        public int? CategoryId { get; set; }

        public ICollection<ProductCustomAttribute> productCustomAttributes { get; set; } = new List<ProductCustomAttribute>();

        public ICollection<ProductInventory> ProductInventories { get; set; } = new List<ProductInventory>();

        public ICollection<ProductPrice> ProductPrices { get; set; } = new List<ProductPrice>();

        public ICollection<OrderLine> orderLines { get; set; } = new List<OrderLine>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Shop.Entites
{
    public class CustomAttributeTemplate
    {
        public int? id { get; set; }

        public int? CategoryId { get; set; }

        public string AttributeTitle { get; set; } = null;

        public Category Category { get; set; } = null;

        public ICollection<ProductCustomAttribute> ProductCustomAttributes { get; set; } = new List<ProductCustomAttribute>();
    }
}

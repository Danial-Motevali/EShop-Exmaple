using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Shop.Entites
{
    public class ProductCustomAttribute
    {
        public int? id { get; set; }

        public string AttributeTitle { get; set; } = null;

        public string AttributeValue { get; set; } = null;

        public int? CustomAttributeTemplateId { get; set; }

        public CustomAttributeTemplate CustomAttributeTemplate { get; set; } = null;

        public int? ProductId { get; set; }

        public Product Product { get; set; } = null;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Shop.Entites
{
    public class Category
    {
        public int? Id { get; set; }

        public string? Title { get; set; } = null;

        public int? ParentId { get; set; }

        public bool? HasProduct { get; set; }

        public ICollection<CustomAttributeTemplate> CustomAttributeTemplates { get; set; } = new List<CustomAttributeTemplate>();

        public ICollection<Product> products { get; set; } = new List<Product>();
    }   
}

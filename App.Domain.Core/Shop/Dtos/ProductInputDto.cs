using App.Domain.Core.Shop.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Shop.Dtos
{
    public class ProductInputDto
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }

        public string? Title { get; set; }

        public int CalculatedQty { get; set; }

        public virtual Category? Category { get; set; }
    }

    public class ProductOutputDto
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryTitle { get; set; }

        public string? Title { get; set; }

        public int CalculatedQty { get; set; }
    }
}

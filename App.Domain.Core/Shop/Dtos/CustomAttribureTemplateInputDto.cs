using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Shop.Dtos
{
    public class CustomAttribureTemplateInputDto
    {
        public int? CategoryId { get; set; }

        public string AttributeTitle { get; set; } = null;
    }

    public class CustomAttribureTemplateOututDto
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string AttributeTitle { get; set; } = null!;
    }
}

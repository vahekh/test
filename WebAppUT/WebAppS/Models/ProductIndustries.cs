using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ProductIndustries
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int IndustryId { get; set; }

        public Industries Industry { get; set; }
        public Products Product { get; set; }
    }
}

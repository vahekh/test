using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ProductBlockPrices
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal Initial { get; set; }
        public decimal? Renewal { get; set; }
        public int CountFrom { get; set; }
        public int? CountTo { get; set; }

        public Products Product { get; set; }
    }
}

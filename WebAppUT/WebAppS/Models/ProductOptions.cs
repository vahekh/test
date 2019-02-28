using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ProductOptions
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int NumPaymentsAllowed { get; set; }
        public decimal Price { get; set; }
        public decimal? RenewalPrice { get; set; }
        public bool IsDefault { get; set; }
        public string Name { get; set; }

        public Products Product { get; set; }
    }
}

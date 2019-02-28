using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class DiscountProducts
    {
        public int Id { get; set; }
        public int DiscountId { get; set; }
        public int ProductId { get; set; }

        public Discounts Discount { get; set; }
        public Products Product { get; set; }
    }
}

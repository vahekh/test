using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class DiscountPrices
    {
        public int Id { get; set; }
        public int DiscountId { get; set; }
        public decimal Initial { get; set; }
        public decimal? Renewal { get; set; }
        public int CountFrom { get; set; }
        public int? CountTo { get; set; }
        public decimal? SetupFee { get; set; }
        public bool IsBlock { get; set; }

        public Discounts Discount { get; set; }
    }
}

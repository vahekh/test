using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Discounts
    {
        public Discounts()
        {
            DiscountPrices = new HashSet<DiscountPrices>();
            DiscountProducts = new HashSet<DiscountProducts>();
        }

        public int Id { get; set; }
        public int WhiteLabelId { get; set; }
        public string DiscountCode { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public bool IsActive { get; set; }
        public int? NumberUses { get; set; }
        public int? DiscountType { get; set; }
        public bool IsCombinable { get; set; }
        public bool IsLimitedToFirstUse { get; set; }
        public int? DaysConsideredNew { get; set; }
        public bool AutoApplyDiscount { get; set; }
        public bool RequireAllProducts { get; set; }
        public int CombiningSequence { get; set; }
        public decimal? MaxAllowedDiscount { get; set; }
        public int AdjustmentType { get; set; }

        public DiscountTypes DiscountTypeNavigation { get; set; }
        public WhiteLabels WhiteLabel { get; set; }
        public ICollection<DiscountPrices> DiscountPrices { get; set; }
        public ICollection<DiscountProducts> DiscountProducts { get; set; }
    }
}

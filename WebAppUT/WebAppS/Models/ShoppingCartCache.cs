using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ShoppingCartCache
    {
        public int Id { get; set; }
        public int WhiteLabelId { get; set; }
        public int ContactPersonId { get; set; }
        public int ProductId { get; set; }
        public int LicenseCount { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public int? DiscountId { get; set; }
        public int? CombinedDiscountId { get; set; }
        public int? IndustryId { get; set; }
        public int? PaymentType { get; set; }
        public decimal? ExpeditePrice { get; set; }
        public string Locations { get; set; }
        public int OptionId { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
        public int AccessInterval { get; set; }

        public Products Product { get; set; }
        public WhiteLabels WhiteLabel { get; set; }
    }
}

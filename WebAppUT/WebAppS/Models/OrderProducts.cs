using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class OrderProducts
    {
        public OrderProducts()
        {
            ClientProducts = new HashSet<ClientProducts>();
            OrderProductSets = new HashSet<OrderProductSets>();
            OrderRenewNotifications = new HashSet<OrderRenewNotifications>();
            PaymentReminds = new HashSet<PaymentReminds>();
            Payments = new HashSet<Payments>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public int LicenseType { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal PaidPrice { get; set; }
        public decimal? SetUpFee { get; set; }
        public int? DiscountId { get; set; }
        public int? CombinedDiscountId { get; set; }
        public int Status { get; set; }
        public bool AutoRenew { get; set; }
        public int? RenewQuantity { get; set; }
        public int? RenewDiscountId { get; set; }
        public int PaymentType { get; set; }
        public decimal? ExpeditePrice { get; set; }
        public DateTimeOffset ExpirationDate { get; set; }
        public int? PreviousId { get; set; }
        public decimal? TotalPrice { get; set; }
        public int OptionId { get; set; }
        public decimal? OriginalSetUpFee { get; set; }
        public int? HubSpotId { get; set; }
        public bool IsBlock { get; set; }
        public int? PayAttempts { get; set; }
        public int? OldProductId { get; set; }
        public bool IsFreeTrial { get; set; }
        public int AccessInterval { get; set; }

        public SystemClients Client { get; set; }
        public Orders Order { get; set; }
        public Products Product { get; set; }
        public ICollection<ClientProducts> ClientProducts { get; set; }
        public ICollection<OrderProductSets> OrderProductSets { get; set; }
        public ICollection<OrderRenewNotifications> OrderRenewNotifications { get; set; }
        public ICollection<PaymentReminds> PaymentReminds { get; set; }
        public ICollection<Payments> Payments { get; set; }
    }
}

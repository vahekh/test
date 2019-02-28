using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class TempTransactions
    {
        public int Id { get; set; }
        public string TransactionId { get; set; }
        public string OrganizationId { get; set; }
        public string LocationId { get; set; }
        public string CustomerToken { get; set; }
        public string CustomerId { get; set; }
        public string OrderNumber { get; set; }
        public string ReferenceId { get; set; }
        public string Status { get; set; }
        public string Action { get; set; }
        public double? AuthorizationAmount { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string AuthorizationCode { get; set; }
        public string EnteredBy { get; set; }
        public string BillingaddressFirstName { get; set; }
        public string BillingaddressLastName { get; set; }
        public string BillingaddressCompanyName { get; set; }
        public string ResponseResponseCode { get; set; }
        public string LinkSettlements { get; set; }
        public string LinkSelf { get; set; }
        public string CardMaskedAccountNumber { get; set; }
        public string CardCardType { get; set; }
        public int? ClientId { get; set; }
        public int? ContacPersonId { get; set; }
        public string PaymentId { get; set; }
        public bool Done { get; set; }
        public int? UserId { get; set; }
        public bool? IsMultiple { get; set; }
        public int ProductId { get; set; }
        public string Email { get; set; }
    }
}

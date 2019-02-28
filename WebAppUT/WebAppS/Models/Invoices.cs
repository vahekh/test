using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Invoices
    {
        public Invoices()
        {
            Payments = new HashSet<Payments>();
            Transactions = new HashSet<Transactions>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int? OrderId { get; set; }
        public int ContactPersonId { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public string UtcTime { get; set; }
        public string HashCode { get; set; }
        public int TransactionStatus { get; set; }
        public string PgTraceNumber { get; set; }
        public string AuthorizationCode { get; set; }
        public int? PaymentMethodId { get; set; }
        public string TransactionType { get; set; }
        public string BillingAddress { get; set; }
        public int UserId { get; set; }
        public string PgResponseCode { get; set; }

        public SystemClients Client { get; set; }
        public Orders Order { get; set; }
        public ICollection<Payments> Payments { get; set; }
        public ICollection<Transactions> Transactions { get; set; }
    }
}

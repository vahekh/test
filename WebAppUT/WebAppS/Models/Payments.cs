using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Payments
    {
        public Payments()
        {
            ClientProducts = new HashSet<ClientProducts>();
            PaymentReminds = new HashSet<PaymentReminds>();
        }

        public int Id { get; set; }
        public int OrderId { get; set; }
        public int OrderProductId { get; set; }
        public int? InvoiceId { get; set; }
        public int? PlanId { get; set; }
        public decimal Amount { get; set; }
        public DateTimeOffset ProcessDate { get; set; }
        public int Status { get; set; }
        public int Sequence { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public string PgscheduleItemId { get; set; }
        public DateTimeOffset? ExpirationDate { get; set; }
        public int PayAttempts { get; set; }

        public Invoices Invoice { get; set; }
        public Orders Order { get; set; }
        public OrderProducts OrderProduct { get; set; }
        public SubscriptionPlans Plan { get; set; }
        public ICollection<ClientProducts> ClientProducts { get; set; }
        public ICollection<PaymentReminds> PaymentReminds { get; set; }
    }
}

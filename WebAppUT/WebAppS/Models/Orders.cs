using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Orders
    {
        public Orders()
        {
            Invoices = new HashSet<Invoices>();
            OrderProducts = new HashSet<OrderProducts>();
            Payments = new HashSet<Payments>();
        }

        public int Id { get; set; }
        public int WhiteLabelId { get; set; }
        public int ClientId { get; set; }
        public int? ContactPersonId { get; set; }
        public string Number { get; set; }
        public bool AutoAssignProducts { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public bool IsSystem { get; set; }
        public int? PaymentMethodId { get; set; }
        public int? UserId { get; set; }

        public SystemClients Client { get; set; }
        public WhiteLabels WhiteLabel { get; set; }
        public ICollection<Invoices> Invoices { get; set; }
        public ICollection<OrderProducts> OrderProducts { get; set; }
        public ICollection<Payments> Payments { get; set; }
    }
}

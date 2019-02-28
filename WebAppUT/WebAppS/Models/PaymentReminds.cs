using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class PaymentReminds
    {
        public int Id { get; set; }
        public int ActionReminderId { get; set; }
        public int ClientId { get; set; }
        public int OrderProductId { get; set; }
        public int? PaymentId { get; set; }
        public DateTimeOffset CreateDate { get; set; }

        public ActionReminders ActionReminder { get; set; }
        public SystemClients Client { get; set; }
        public OrderProducts OrderProduct { get; set; }
        public Payments Payment { get; set; }
    }
}

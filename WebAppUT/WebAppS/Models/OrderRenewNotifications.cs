using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class OrderRenewNotifications
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int OrderProductId { get; set; }
        public int NotifyNumber { get; set; }
        public DateTimeOffset CreateDate { get; set; }

        public SystemClients Client { get; set; }
        public OrderProducts OrderProduct { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class EscalationHistory
    {
        public int Id { get; set; }
        public int SetAssignedId { get; set; }
        public int NotifyNumber { get; set; }
        public int UserId { get; set; }
        public int? EmailDistributionListId { get; set; }
        public DateTime? AddDate { get; set; }
        public int ClientId { get; set; }
        public int EscalationType { get; set; }
        public int NotificationListType { get; set; }

        public Employees User { get; set; }
    }
}

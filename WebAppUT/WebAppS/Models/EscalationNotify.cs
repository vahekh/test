using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class EscalationNotify
    {
        public int Id { get; set; }
        public int EscalationId { get; set; }
        public int Notify { get; set; }
        public bool NotifyAfter { get; set; }
        public int? EmailDistributionListId { get; set; }
        public int ClientId { get; set; }
        public int EscalationType { get; set; }
        public int NotificationListType { get; set; }
        public string Guid { get; set; }
        public bool IsDeleted { get; set; }
    }
}

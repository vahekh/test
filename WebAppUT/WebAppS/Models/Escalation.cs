using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Escalation
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public int? NotifyBefore1 { get; set; }
        public int? NotifyBefore2 { get; set; }
        public int? NotifyBefore3 { get; set; }
        public TimeSpan? NotifyTime { get; set; }
        public bool NotifyAfter { get; set; }
        public int? EmailDistributionListId { get; set; }
        public bool? IsActive { get; set; }
        public bool NotifyNow { get; set; }

        public EmailDistributionList EmailDistributionList { get; set; }
    }
}

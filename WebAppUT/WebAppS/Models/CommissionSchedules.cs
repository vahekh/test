using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class CommissionSchedules
    {
        public CommissionSchedules()
        {
            CommissionScheduleGroups = new HashSet<CommissionScheduleGroups>();
        }

        public int Id { get; set; }
        public int WhiteLabelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int PayAfterCfd { get; set; }
        public int AdjustmentType { get; set; }
        public decimal Initial { get; set; }
        public decimal? Renewal { get; set; }
        public bool? IsIncludePaid { get; set; }
        public bool IsIncludeSetup { get; set; }
        public bool IsIncludeExpedite { get; set; }

        public WhiteLabels WhiteLabel { get; set; }
        public ICollection<CommissionScheduleGroups> CommissionScheduleGroups { get; set; }
    }
}

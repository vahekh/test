using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class CommissionScheduleGroups
    {
        public int Id { get; set; }
        public int CommissionScheduleId { get; set; }
        public int CommissionGroupId { get; set; }

        public CommissionGroups CommissionGroup { get; set; }
        public CommissionSchedules CommissionSchedule { get; set; }
    }
}

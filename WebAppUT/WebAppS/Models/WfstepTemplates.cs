using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class WfstepTemplates
    {
        public WfstepTemplates()
        {
            WfclientTasks = new HashSet<WfclientTasks>();
        }

        public int Id { get; set; }
        public int WfstepId { get; set; }
        public int AssignClient { get; set; }
        public int AssignEmployeeSet { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TaskInfoSet { get; set; }
        public int TemplateType { get; set; }
        public string Question { get; set; }
        public int? Answer { get; set; }
        public int ExpireType { get; set; }
        public int RecurrenceMethod { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }
        public int RangeOfRecurenceMethod { get; set; }
        public int? Occurrence { get; set; }
        public int? DelayDays { get; set; }
        public bool IsAdditionalinfo { get; set; }

        public Wfsteps Wfstep { get; set; }
        public ICollection<WfclientTasks> WfclientTasks { get; set; }
    }
}

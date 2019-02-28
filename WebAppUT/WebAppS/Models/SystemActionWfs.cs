using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SystemActionWfs
    {
        public SystemActionWfs()
        {
            SystemActionWffilters = new HashSet<SystemActionWffilters>();
        }

        public int Id { get; set; }
        public int ActionId { get; set; }
        public int WorkfFlowId { get; set; }
        public int? IndustryId { get; set; }
        public int Priority { get; set; }
        public bool IsEnd { get; set; }

        public SystemActions Action { get; set; }
        public WorkfFlow WorkfFlow { get; set; }
        public ICollection<SystemActionWffilters> SystemActionWffilters { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Wfsteps
    {
        public Wfsteps()
        {
            WfstepTemplates = new HashSet<WfstepTemplates>();
            WfstepsDiagram = new HashSet<WfstepsDiagram>();
            WfstepsParameters = new HashSet<WfstepsParameters>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int WorkFlowId { get; set; }
        public double? PositionX { get; set; }
        public double? PositionY { get; set; }
        public int? ActionId { get; set; }
        public int? ParameterId { get; set; }
        public int? ActionStatus { get; set; }
        public int? RecurrenceMonth { get; set; }

        public WorkfFlow WorkFlow { get; set; }
        public ICollection<WfstepTemplates> WfstepTemplates { get; set; }
        public ICollection<WfstepsDiagram> WfstepsDiagram { get; set; }
        public ICollection<WfstepsParameters> WfstepsParameters { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class WfstepsDiagram
    {
        public int Id { get; set; }
        public int WfstepId { get; set; }
        public int WfparentStepId { get; set; }
        public int? Answer { get; set; }
        public int WfedgeType { get; set; }

        public Wfsteps Wfstep { get; set; }
    }
}

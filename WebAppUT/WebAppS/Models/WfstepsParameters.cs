using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class WfstepsParameters
    {
        public int Id { get; set; }
        public int WfstepId { get; set; }
        public int ParameterId { get; set; }

        public Wfsteps Wfstep { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class WalkThroughs
    {
        public WalkThroughs()
        {
            WalkThroughAssigns = new HashSet<WalkThroughAssigns>();
            WalkThroughProfiles = new HashSet<WalkThroughProfiles>();
            WalkThroughSteps = new HashSet<WalkThroughSteps>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Active { get; set; }

        public ICollection<WalkThroughAssigns> WalkThroughAssigns { get; set; }
        public ICollection<WalkThroughProfiles> WalkThroughProfiles { get; set; }
        public ICollection<WalkThroughSteps> WalkThroughSteps { get; set; }
    }
}

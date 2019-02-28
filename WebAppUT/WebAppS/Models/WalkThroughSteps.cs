using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class WalkThroughSteps
    {
        public int Id { get; set; }
        public int WalkthroughId { get; set; }
        public string PageUrl { get; set; }
        public string Container { get; set; }
        public string ElementId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Placement { get; set; }
        public bool Required { get; set; }

        public WalkThroughs Walkthrough { get; set; }
    }
}

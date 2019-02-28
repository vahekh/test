using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class WalkThroughAssigns
    {
        public int Id { get; set; }
        public int WalkThroughId { get; set; }
        public int? IndustryId { get; set; }
        public int? ClientId { get; set; }

        public SystemClients Client { get; set; }
        public Industries Industry { get; set; }
        public WalkThroughs WalkThrough { get; set; }
    }
}

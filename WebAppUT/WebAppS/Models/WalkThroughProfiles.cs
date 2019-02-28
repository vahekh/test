using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class WalkThroughProfiles
    {
        public int Id { get; set; }
        public int WalkThroughId { get; set; }
        public int PermissionTypeId { get; set; }

        public WalkThroughs WalkThrough { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SetRegions
    {
        public int Id { get; set; }
        public int RegionId { get; set; }
        public int SetId { get; set; }

        public Regions Region { get; set; }
        public Sets Set { get; set; }
    }
}

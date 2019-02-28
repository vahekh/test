using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Regions
    {
        public Regions()
        {
            SetRegions = new HashSet<SetRegions>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public string RegionName { get; set; }

        public SystemClients Client { get; set; }
        public ICollection<SetRegions> SetRegions { get; set; }
    }
}

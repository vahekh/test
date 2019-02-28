using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SystemGroups
    {
        public int Id { get; set; }
        public int MasterClientId { get; set; }
        public int VendorClientId { get; set; }
        public int VendorGroupId { get; set; }
        public string MasterGroupName { get; set; }
        public bool? IsActive { get; set; }

        public SystemClients VendorClient { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class WhiteLabelHosts
    {
        public WhiteLabelHosts()
        {
            WhiteLabelLinks = new HashSet<WhiteLabelLinks>();
        }

        public int Id { get; set; }
        public int WhiteLabelId { get; set; }
        public string Name { get; set; }
        public byte[] Logo { get; set; }
        public string BlobName { get; set; }
        public int HostType { get; set; }

        public WhiteLabels WhiteLabel { get; set; }
        public ICollection<WhiteLabelLinks> WhiteLabelLinks { get; set; }
    }
}

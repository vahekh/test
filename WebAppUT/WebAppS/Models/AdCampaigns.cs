using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class AdCampaigns
    {
        public AdCampaigns()
        {
            AdTrackings = new HashSet<AdTrackings>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<AdTrackings> AdTrackings { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class AdTrackings
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public string Url { get; set; }
        public string ReferringUrl { get; set; }
        public string Ip { get; set; }
        public string Browser { get; set; }
        public string GasessionId { get; set; }
        public DateTimeOffset CreateDate { get; set; }

        public AdCampaigns Campaign { get; set; }
    }
}

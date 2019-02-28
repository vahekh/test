using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SalesPersons
    {
        public SalesPersons()
        {
            KeyIndicatorValues = new HashSet<KeyIndicatorValues>();
            SalesPersonClients = new HashSet<SalesPersonClients>();
            SalesPersonGroups = new HashSet<SalesPersonGroups>();
            Transactions = new HashSet<Transactions>();
        }

        public int Id { get; set; }
        public int WhiteLabelId { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
        public int IndustryId { get; set; }
        public int? GroupId { get; set; }
        public bool? IsActive { get; set; }
        public bool IsChannelPartner { get; set; }
        public int? HubSpotOwnerId { get; set; }

        public Industries Industry { get; set; }
        public WhiteLabels WhiteLabel { get; set; }
        public ICollection<KeyIndicatorValues> KeyIndicatorValues { get; set; }
        public ICollection<SalesPersonClients> SalesPersonClients { get; set; }
        public ICollection<SalesPersonGroups> SalesPersonGroups { get; set; }
        public ICollection<Transactions> Transactions { get; set; }
    }
}

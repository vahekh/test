using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class EventTemplates
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Topic { get; set; }
        public string Subject { get; set; }
        public DateTimeOffset FromDate { get; set; }
        public DateTimeOffset ToDate { get; set; }
        public int? SetId { get; set; }
        public string Description { get; set; }
        public int? AttachmenId { get; set; }

        public EventsAttachedFile Attachmen { get; set; }
        public Sets Set { get; set; }
    }
}

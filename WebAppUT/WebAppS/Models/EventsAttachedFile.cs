using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class EventsAttachedFile
    {
        public EventsAttachedFile()
        {
            EventTemplates = new HashSet<EventTemplates>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Guid { get; set; }
        public string MimeType { get; set; }
        public int? EventId { get; set; }
        public int ClientId { get; set; }
        public string BlobName { get; set; }

        public SystemClients Client { get; set; }
        public Events Event { get; set; }
        public ICollection<EventTemplates> EventTemplates { get; set; }
    }
}

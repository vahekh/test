using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class EventsLogo
    {
        public EventsLogo()
        {
            Events = new HashSet<Events>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string MimeType { get; set; }
        public byte[] Data { get; set; }
        public int ClientId { get; set; }
        public string BlobName { get; set; }

        public SystemClients Client { get; set; }
        public ICollection<Events> Events { get; set; }
    }
}

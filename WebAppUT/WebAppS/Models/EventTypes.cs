using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class EventTypes
    {
        public EventTypes()
        {
            Events = new HashSet<Events>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] LogoFile { get; set; }
        public int ClientId { get; set; }

        public SystemClients Client { get; set; }
        public ICollection<Events> Events { get; set; }
    }
}

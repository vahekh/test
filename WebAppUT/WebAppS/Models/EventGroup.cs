using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class EventGroup
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public int ClientId { get; set; }

        public SystemClients Client { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class EventProducts
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EventId { get; set; }
        public int ProductId { get; set; }

        public SystemClients Client { get; set; }
        public Events Event { get; set; }
    }
}

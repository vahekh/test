using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class DeliveryMethods
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ClientId { get; set; }

        public SystemClients Client { get; set; }
    }
}

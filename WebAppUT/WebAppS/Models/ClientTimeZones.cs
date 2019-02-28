using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ClientTimeZones
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string TimeZone { get; set; }
        public string CustomName { get; set; }
    }
}

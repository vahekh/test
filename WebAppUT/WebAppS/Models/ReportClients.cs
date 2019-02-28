using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ReportClients
    {
        public int Id { get; set; }
        public int ReportId { get; set; }
        public int ClientId { get; set; }

        public SystemClients Client { get; set; }
        public Reports Report { get; set; }
    }
}

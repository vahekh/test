using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ClientsReports
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ReportId { get; set; }
    }
}

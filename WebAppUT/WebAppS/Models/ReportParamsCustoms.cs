using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ReportParamsCustoms
    {
        public int Id { get; set; }
        public int ReportId { get; set; }
        public int TypeId { get; set; }

        public ReportsCustoms Report { get; set; }
    }
}

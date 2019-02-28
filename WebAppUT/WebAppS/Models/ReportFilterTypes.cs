using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ReportFilterTypes
    {
        public int Id { get; set; }
        public int ReportTypeId { get; set; }
        public int FilterTypeId { get; set; }
    }
}

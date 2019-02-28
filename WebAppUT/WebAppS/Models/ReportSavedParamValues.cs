using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ReportSavedParamValues
    {
        public int Id { get; set; }
        public int ReportSavedParamId { get; set; }
        public int TypeId { get; set; }
        public string Value { get; set; }

        public ReportSavedParams ReportSavedParam { get; set; }
    }
}

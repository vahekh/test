using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ReportParams
    {
        public int Id { get; set; }
        public int ReportId { get; set; }
        public int TypeId { get; set; }
        public string SpparamName { get; set; }
        public string SpdisplayName { get; set; }

        public Reports Report { get; set; }
    }
}

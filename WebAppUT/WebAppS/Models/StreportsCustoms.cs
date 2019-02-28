using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class StreportsCustoms
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public int StreportsId { get; set; }
        public string ReportName { get; set; }
        public string Layout { get; set; }
        public bool IsFullJoin { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class EmployeesFavoriteReports
    {
        public int Id { get; set; }
        public int ReportId { get; set; }
        public int EmployeeId { get; set; }
        public bool IsSystem { get; set; }

        public Employees Employee { get; set; }
    }
}

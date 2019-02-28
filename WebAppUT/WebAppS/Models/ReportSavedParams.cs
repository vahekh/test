using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ReportSavedParams
    {
        public ReportSavedParams()
        {
            ReportSavedParamValues = new HashSet<ReportSavedParamValues>();
        }

        public int Id { get; set; }
        public int ReportId { get; set; }
        public int EmployeeId { get; set; }
        public bool IsSystem { get; set; }
        public int SaveTypeId { get; set; }
        public string Name { get; set; }

        public Employees Employee { get; set; }
        public ICollection<ReportSavedParamValues> ReportSavedParamValues { get; set; }
    }
}

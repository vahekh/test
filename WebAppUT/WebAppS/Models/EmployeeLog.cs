using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class EmployeeLog
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int? EmployeeId { get; set; }
        public int? TrainingId { get; set; }
        public int? AssignmentId { get; set; }
        public DateTime StartDateTime { get; set; }
        public int? DocumentId { get; set; }
        public int? TrainingFlow { get; set; }
        public int? TrainingLanguage { get; set; }
        public int? TrainingMode { get; set; }
        public int LogType { get; set; }
        public string Ipaddress { get; set; }
        public string DeviceType { get; set; }
        public string Browser { get; set; }

        public Employees Employee { get; set; }
    }
}

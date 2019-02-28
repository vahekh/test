using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Slconfiguration
    {
        public int Id { get; set; }
        public int DefaultVersion { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime DateOfLastEdit { get; set; }
        public string Comments { get; set; }
        public int? ModuleId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class EmployeeAdditionalInformation
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public int InfoType { get; set; }
        public string InfoValue { get; set; }
        public DateTime? InfoDate { get; set; }
        public bool? IsActive { get; set; }
        public int ChangedByClientId { get; set; }
        public int ChangedByEmployeeId { get; set; }
        public DateTime ChangedDate { get; set; }

        public SystemClients Client { get; set; }
        public Employees Employee { get; set; }
    }
}

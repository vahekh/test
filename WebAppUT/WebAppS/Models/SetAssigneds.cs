using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SetAssigneds
    {
        public int Id { get; set; }
        public int? SetId { get; set; }
        public int SetType { get; set; }
        public int AssignedId { get; set; }
        public int AssignedType { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? AssignedDate { get; set; }
        public int? DelayStart { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public int? CompletionDays { get; set; }
        public DateTime? CompletionDate { get; set; }
        public int? ActionAfterCd { get; set; }
        public int? EscalationsId { get; set; }
        public bool RepeatAnnually { get; set; }
        public int ClientId { get; set; }

        public SystemClients Client { get; set; }
        public Sets Set { get; set; }
    }
}

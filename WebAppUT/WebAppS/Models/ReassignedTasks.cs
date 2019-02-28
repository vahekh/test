using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ReassignedTasks
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public int TaskId { get; set; }
        public int ReassignedClientId { get; set; }
        public int ReassignedEmployeeId { get; set; }
        public int Duration { get; set; }

        public SystemClients Client { get; set; }
        public Employees Employee { get; set; }
        public ClientAssignments Task { get; set; }
    }
}

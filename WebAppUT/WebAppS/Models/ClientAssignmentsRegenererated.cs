using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ClientAssignmentsRegenererated
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ClientAssignmentId { get; set; }
        public int? CompletedAssignmentId { get; set; }
        public int ClientId { get; set; }

        public ClientAssignments ClientAssignment { get; set; }
        public AssignmentsCompleted CompletedAssignment { get; set; }
    }
}

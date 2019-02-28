using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class AssignmentsCompleted
    {
        public AssignmentsCompleted()
        {
            ClientAssignmentsRegenererated = new HashSet<ClientAssignmentsRegenererated>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public int AssignmentId { get; set; }
        public DateTime AssignmentFinishDate { get; set; }
        public string AdditionalInformation { get; set; }
        public DateTime? AssignmentPracticalFinishDate { get; set; }
        public bool? Expired { get; set; }
        public int? ReassignedClientId { get; set; }
        public int? ReassignedEmployeeId { get; set; }
        public int? Occurred { get; set; }
        public int? GroupTrainingId { get; set; }
        public int? Score { get; set; }
        public int? CompletedMethod { get; set; }
        public int? CreditHours { get; set; }
        public bool? IsExempt { get; set; }
        public int? PracticalExamId { get; set; }
        public int Status { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }

        public ClientAssignments Assignment { get; set; }
        public Employees Employee { get; set; }
        public ICollection<ClientAssignmentsRegenererated> ClientAssignmentsRegenererated { get; set; }
    }
}

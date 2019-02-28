using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ClientAssignments
    {
        public ClientAssignments()
        {
            AssignmentQuestions = new HashSet<AssignmentQuestions>();
            AssignmentsCompleted = new HashSet<AssignmentsCompleted>();
            ClientAssignmentsRegenererated = new HashSet<ClientAssignmentsRegenererated>();
            ReassignedTasks = new HashSet<ReassignedTasks>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Attachment { get; set; }
        public bool IsAdministratorVerification { get; set; }
        public int? OwnerOfAssignment { get; set; }
        public int Expire { get; set; }
        public int ExpireType { get; set; }
        public int? AvailableLicenses { get; set; }
        public int RecurrenceMethod { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }
        public DateTime? StartDate { get; set; }
        public int? Occurrence { get; set; }
        public DateTime? EndDate { get; set; }
        public int RangeOfRecurenceMethod { get; set; }
        public int? ScoreType { get; set; }
        public int? Percentage { get; set; }
        public int? CertificationId { get; set; }
        public string Unit { get; set; }
        public string UnitType { get; set; }
        public bool? IsCertificationEvent { get; set; }
        public int? CreditHours { get; set; }
        public int? SubjectId { get; set; }
        public DateTime? ImportDate { get; set; }
        public bool IsPracticalExamRequired { get; set; }
        public int? TaskInfo { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public int? TaskCreator { get; set; }
        public bool? Expired { get; set; }
        public int? TaskInfoClientId { get; set; }
        public int? TaskCreatorClientId { get; set; }
        public int TaskType { get; set; }
        public bool IsAdditionalinfo { get; set; }
        public bool IsAllowAttachFile { get; set; }
        public int? EstMinutesReq { get; set; }
        public int? WfstepId { get; set; }
        public decimal? Cost { get; set; }
        public int? OrderProductId { get; set; }

        public Subject Subject { get; set; }
        public ICollection<AssignmentQuestions> AssignmentQuestions { get; set; }
        public ICollection<AssignmentsCompleted> AssignmentsCompleted { get; set; }
        public ICollection<ClientAssignmentsRegenererated> ClientAssignmentsRegenererated { get; set; }
        public ICollection<ReassignedTasks> ReassignedTasks { get; set; }
    }
}

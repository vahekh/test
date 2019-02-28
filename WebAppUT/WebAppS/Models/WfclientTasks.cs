using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class WfclientTasks
    {
        public int Id { get; set; }
        public int WfstepId { get; set; }
        public int ClientId { get; set; }
        public int? ClientAssignmentId { get; set; }
        public int? SetAssignId { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public bool IsCompleted { get; set; }
        public int ActionLogId { get; set; }
        public int ParentCount { get; set; }
        public int? WfstepTemplateId { get; set; }
        public int? ActionId { get; set; }
        public int? ParameterId { get; set; }
        public int? ProductId { get; set; }
        public string ProductName { get; set; }
        public int? Answer { get; set; }
        public int? AssignEmployeeSetId { get; set; }
        public int? AssignClientId { get; set; }
        public int? ActionStatus { get; set; }
        public int? RecurrenceMonth { get; set; }
        public int? ParentWfclientTaskId { get; set; }
        public bool Recurred { get; set; }

        public ActionLogs ActionLog { get; set; }
        public WfstepTemplates WfstepTemplate { get; set; }
    }
}

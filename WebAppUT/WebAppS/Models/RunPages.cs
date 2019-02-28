using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class RunPages
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public int TrainingId { get; set; }
        public int FlowId { get; set; }
        public DateTime? TrainingStarted { get; set; }
        public DateTime? LastTimeAccessed { get; set; }
        public bool IsAutomatic { get; set; }
        public int? RunLogId { get; set; }
        public bool IsActive { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsRestartedInternal { get; set; }
        public bool IsRestartedBookmark { get; set; }
        public bool IsDeleted { get; set; }
        public string TrainingName { get; set; }
        public int? Chapter { get; set; }
        public int? Page { get; set; }
        public int? Seq { get; set; }

        public Employees Employee { get; set; }
    }
}

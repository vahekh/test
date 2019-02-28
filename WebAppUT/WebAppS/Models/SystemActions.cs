using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SystemActions
    {
        public SystemActions()
        {
            ActionLogs = new HashSet<ActionLogs>();
            ActionReminders = new HashSet<ActionReminders>();
            ProductActions = new HashSet<ProductActions>();
            SystemActionWfs = new HashSet<SystemActionWfs>();
        }

        public int Id { get; set; }
        public int ActionTypeId { get; set; }
        public string Name { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsTextMessage { get; set; }
        public bool IsInternal { get; set; }
        public int? WorkFlowId { get; set; }
        public int? FilterType { get; set; }
        public int Priority { get; set; }

        public SystemActionTypes ActionType { get; set; }
        public ICollection<ActionLogs> ActionLogs { get; set; }
        public ICollection<ActionReminders> ActionReminders { get; set; }
        public ICollection<ProductActions> ProductActions { get; set; }
        public ICollection<SystemActionWfs> SystemActionWfs { get; set; }
    }
}

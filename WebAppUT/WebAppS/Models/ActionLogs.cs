using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ActionLogs
    {
        public ActionLogs()
        {
            WfclientTasks = new HashSet<WfclientTasks>();
        }

        public int Id { get; set; }
        public int ActionId { get; set; }
        public int ClientId { get; set; }
        public int? UserId { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset? ExecutedDate { get; set; }
        public int Status { get; set; }
        public string Parametrs { get; set; }
        public int? ParameterId { get; set; }

        public SystemActions Action { get; set; }
        public ICollection<WfclientTasks> WfclientTasks { get; set; }
    }
}

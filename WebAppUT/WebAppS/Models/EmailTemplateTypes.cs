using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class EmailTemplateTypes
    {
        public EmailTemplateTypes()
        {
            ActionFilter = new HashSet<ActionFilter>();
        }

        public int Id { get; set; }
        public int TemplateId { get; set; }
        public int CustomTemplateId { get; set; }
        public bool IsSystem { get; set; }
        public int ClientId { get; set; }
        public int? NotificationListId { get; set; }
        public int NotificationListType { get; set; }
        public int Priority { get; set; }
        public bool IsEnd { get; set; }

        public ICollection<ActionFilter> ActionFilter { get; set; }
    }
}

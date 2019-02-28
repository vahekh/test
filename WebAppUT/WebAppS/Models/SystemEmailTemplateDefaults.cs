using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SystemEmailTemplateDefaults
    {
        public int Id { get; set; }
        public int EnumTemplateId { get; set; }
        public int SystemTemplateId { get; set; }
        public int? NotificationListId { get; set; }
        public int? IndustryId { get; set; }
        public int Priority { get; set; }
        public bool IsEnd { get; set; }

        public SystemNotificationList NotificationList { get; set; }
    }
}

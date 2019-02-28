using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SystemNotificationList
    {
        public SystemNotificationList()
        {
            SystemEmailTemplateDefaults = new HashSet<SystemEmailTemplateDefaults>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool EmailUser { get; set; }
        public bool EmailSupervisor { get; set; }
        public bool EmailManager { get; set; }
        public bool EmailSalesPerson { get; set; }
        public string EmailList { get; set; }
        public bool IsActive { get; set; }
        public int? PermissionTypeId { get; set; }

        public ICollection<SystemEmailTemplateDefaults> SystemEmailTemplateDefaults { get; set; }
    }
}

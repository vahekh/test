using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class EmailDistributionList
    {
        public EmailDistributionList()
        {
            EmailDistributionUsers = new HashSet<EmailDistributionUsers>();
            Escalation = new HashSet<Escalation>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public bool EmailUser { get; set; }
        public bool EmailSupervisor { get; set; }
        public bool EmailManager { get; set; }
        public string EmailList { get; set; }
        public bool? IsActive { get; set; }
        public bool EmailSalesPerson { get; set; }
        public int? SetId { get; set; }
        public int? PermissionTypeId { get; set; }

        public Sets Set { get; set; }
        public ICollection<EmailDistributionUsers> EmailDistributionUsers { get; set; }
        public ICollection<Escalation> Escalation { get; set; }
    }
}

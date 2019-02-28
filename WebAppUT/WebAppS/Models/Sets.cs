using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Sets
    {
        public Sets()
        {
            EmailDistributionList = new HashSet<EmailDistributionList>();
            EventTemplates = new HashSet<EventTemplates>();
            InverseParent = new HashSet<Sets>();
            SetAssigneds = new HashSet<SetAssigneds>();
            SetDetails = new HashSet<SetDetails>();
            SetRegions = new HashSet<SetRegions>();
            SetUserAssigneds = new HashSet<SetUserAssigneds>();
            SetUserManaged = new HashSet<SetUserManaged>();
        }

        public int Id { get; set; }
        public int SetTopId { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public int? PreviousId { get; set; }
        public DateTime? ImportDate { get; set; }
        public int ClientId { get; set; }
        public DateTimeOffset? CreateDate { get; set; }
        public bool? IsActive { get; set; }
        public int? SupervisorId { get; set; }
        public int? ManagerId { get; set; }
        public int? ReportingId { get; set; }

        public SystemClients Client { get; set; }
        public Sets Parent { get; set; }
        public SetTops SetTop { get; set; }
        public Employees Supervisor { get; set; }
        public ICollection<EmailDistributionList> EmailDistributionList { get; set; }
        public ICollection<EventTemplates> EventTemplates { get; set; }
        public ICollection<Sets> InverseParent { get; set; }
        public ICollection<SetAssigneds> SetAssigneds { get; set; }
        public ICollection<SetDetails> SetDetails { get; set; }
        public ICollection<SetRegions> SetRegions { get; set; }
        public ICollection<SetUserAssigneds> SetUserAssigneds { get; set; }
        public ICollection<SetUserManaged> SetUserManaged { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Mailings
    {
        public Mailings()
        {
            MailingAttachments = new HashSet<MailingAttachments>();
            MailingViews = new HashSet<MailingViews>();
        }

        public int Id { get; set; }
        public int? SenderClientId { get; set; }
        public int? SenderEmployeeId { get; set; }
        public int? ClientId { get; set; }
        public int? EmployeeId { get; set; }
        public string Email { get; set; }
        public string Cc { get; set; }
        public int ActionId { get; set; }
        public bool IsSystem { get; set; }
        public string Template { get; set; }
        public string Subject { get; set; }
        public string FromName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? SentDate { get; set; }
        public bool Error { get; set; }
        public DateTime? ProcessDate { get; set; }
        public int? TemplateId { get; set; }
        public string PhoneNumber { get; set; }
        public string TextMessage { get; set; }
        public int Priority { get; set; }

        public ICollection<MailingAttachments> MailingAttachments { get; set; }
        public ICollection<MailingViews> MailingViews { get; set; }
    }
}

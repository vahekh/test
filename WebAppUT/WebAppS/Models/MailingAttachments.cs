using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class MailingAttachments
    {
        public int Id { get; set; }
        public int? MailingId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public byte[] Data { get; set; }
        public int? ActionPendingId { get; set; }

        public Mailings Mailing { get; set; }
    }
}

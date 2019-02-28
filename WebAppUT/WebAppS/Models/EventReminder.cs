using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class EventReminder
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int InvitationId { get; set; }
        public int TypeOfReminder { get; set; }
        public string Email { get; set; }
        public string EmailContent { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? SendDate { get; set; }
        public DateTime? EventStartDate { get; set; }
        public string EmailCc { get; set; }
        public string EmailSubject { get; set; }
        public string EmailFrom { get; set; }
        public string Params { get; set; }
        public int ClientId { get; set; }

        public SystemClients Client { get; set; }
    }
}

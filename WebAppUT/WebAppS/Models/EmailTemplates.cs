using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class EmailTemplates
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Template { get; set; }
        public string FromAddress { get; set; }
        public string Subject { get; set; }
        public int Type { get; set; }
        public bool? AllowFromSendEmail { get; set; }
        public string TextMessage { get; set; }
        public int ClientId { get; set; }

        public SystemClients Client { get; set; }
    }
}

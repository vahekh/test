using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class MailingViews
    {
        public int Id { get; set; }
        public int MailingId { get; set; }
        public string Ip { get; set; }
        public string Browser { get; set; }
        public DateTime Date { get; set; }

        public Mailings Mailing { get; set; }
    }
}

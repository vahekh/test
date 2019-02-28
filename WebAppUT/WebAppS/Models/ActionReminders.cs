using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ActionReminders
    {
        public ActionReminders()
        {
            PaymentReminds = new HashSet<PaymentReminds>();
        }

        public int Id { get; set; }
        public int ActionId { get; set; }
        public int? ClientId { get; set; }
        public string Name { get; set; }
        public int SuccessActionId { get; set; }
        public int? FailActionId { get; set; }
        public int Days { get; set; }
        public DateTimeOffset CreateDate { get; set; }

        public SystemActions Action { get; set; }
        public SystemClients Client { get; set; }
        public ICollection<PaymentReminds> PaymentReminds { get; set; }
    }
}

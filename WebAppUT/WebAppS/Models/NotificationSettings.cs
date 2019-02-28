using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class NotificationSettings
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public int NotificationTypeId { get; set; }
        public int? EveryNthDay { get; set; }
        public string WeekDays { get; set; }
        public string MonthDays { get; set; }
        public int RemoveUnsentDay { get; set; }
        public int? FirstRenewalNotice { get; set; }
        public int? SecondRenewalNotice { get; set; }
        public string TimeZone { get; set; }

        public SystemClients Client { get; set; }
    }
}

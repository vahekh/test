using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class EventParticipantScore
    {
        public int Id { get; set; }
        public int EventParticipantId { get; set; }
        public int? CourseId { get; set; }
        public int? SetType { get; set; }
        public int ScoreType { get; set; }
        public string Score { get; set; }
        public string CreditHours { get; set; }

        public EventParticipants EventParticipant { get; set; }
    }
}

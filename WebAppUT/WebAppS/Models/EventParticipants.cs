using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class EventParticipants
    {
        public EventParticipants()
        {
            EventParticipantScore = new HashSet<EventParticipantScore>();
        }

        public int Id { get; set; }
        public int EventId { get; set; }
        public int? InvitationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string AdditionalInfo { get; set; }
        public DateTime RegistrationTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public bool Rejected { get; set; }
        public bool Finished { get; set; }
        public string Score { get; set; }
        public string CreditHours { get; set; }
        public int? EmployeeId { get; set; }
        public double? CehourF { get; set; }

        public Events Event { get; set; }
        public EventInvitations Invitation { get; set; }
        public ICollection<EventParticipantScore> EventParticipantScore { get; set; }
    }
}

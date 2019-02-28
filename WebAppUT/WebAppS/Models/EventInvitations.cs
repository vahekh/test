using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class EventInvitations
    {
        public EventInvitations()
        {
            EventParticipants = new HashSet<EventParticipants>();
        }

        public int Id { get; set; }
        public int EventId { get; set; }
        public int? EmployeeId { get; set; }
        public string Guid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string AdditionalInfo { get; set; }
        public bool Required { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }

        public Employees Employee { get; set; }
        public Events Event { get; set; }
        public ICollection<EventParticipants> EventParticipants { get; set; }
    }
}

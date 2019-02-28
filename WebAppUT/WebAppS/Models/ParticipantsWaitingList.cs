using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ParticipantsWaitingList
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EventId { get; set; }
        public int? EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? WaitingDateTime { get; set; }
        public DateTime? NotifiedDateTime { get; set; }
        public bool IsWaiting { get; set; }
        public int Status { get; set; }
    }
}

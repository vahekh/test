using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Subject
    {
        public Subject()
        {
            ClientAssignments = new HashSet<ClientAssignments>();
            ClientTrainings = new HashSet<ClientTrainings>();
            Events = new HashSet<Events>();
        }

        public int Id { get; set; }
        public string SubjectName { get; set; }
        public DateTime? ImportDate { get; set; }
        public int ClientId { get; set; }

        public SystemClients Client { get; set; }
        public ICollection<ClientAssignments> ClientAssignments { get; set; }
        public ICollection<ClientTrainings> ClientTrainings { get; set; }
        public ICollection<Events> Events { get; set; }
    }
}

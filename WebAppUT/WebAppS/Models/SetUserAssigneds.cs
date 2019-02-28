using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SetUserAssigneds
    {
        public int Id { get; set; }
        public int SetId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime? ImportDate { get; set; }
        public int ClientId { get; set; }

        public SystemClients Client { get; set; }
        public Employees Employee { get; set; }
        public Sets Set { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Notifications
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public int ActionId { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string EmailTemplate { get; set; }
        public string PhoneNumber { get; set; }
        public string TextMessage { get; set; }
        public DateTime? ProcessDate { get; set; }
        public int Status { get; set; }

        public SystemClients Client { get; set; }
        public Employees Employee { get; set; }
    }
}

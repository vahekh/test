using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class AuthorizedEmployees
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public bool IsLicenseAccepted { get; set; }
        public int ClientId { get; set; }

        public SystemClients Client { get; set; }
        public Employees Employee { get; set; }
    }
}

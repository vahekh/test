using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SystemAdmins
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public bool IsFullAdmin { get; set; }
        public int? Wlpid { get; set; }
        public int? SubClientId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class LayoutSettings
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public bool IncludeAvailable { get; set; }
        public bool IncludeExpired { get; set; }
        public bool IncludeAvailableTasks { get; set; }
        public bool IncludeAllEvents { get; set; }
        public bool IncludeInactiveUsers { get; set; }
        public bool IncludeInactiveClients { get; set; }
        public int? MenuItem { get; set; }
        public bool FavoriteReport { get; set; }
        public int? PageSize { get; set; }
        public bool BasicEventView { get; set; }

        public SystemClients Client { get; set; }
        public Employees Employee { get; set; }
    }
}

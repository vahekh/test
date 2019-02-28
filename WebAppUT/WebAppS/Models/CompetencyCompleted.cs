using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class CompetencyCompleted
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public int CompetencyLevelId { get; set; }
        public DateTimeOffset ExpirationDate { get; set; }

        public CompetencyLevels CompetencyLevel { get; set; }
        public Employees Employee { get; set; }
    }
}

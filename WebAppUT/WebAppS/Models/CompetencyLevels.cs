using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class CompetencyLevels
    {
        public CompetencyLevels()
        {
            CompetencyCompleted = new HashSet<CompetencyCompleted>();
            CompetencyLevelTrainings = new HashSet<CompetencyLevelTrainings>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int? NumberOfTraining { get; set; }
        public int? HoursOfTraining { get; set; }
        public int? NumberOfTasks { get; set; }
        public int? HoursOfTasks { get; set; }
        public int? Modifier { get; set; }

        public ICollection<CompetencyCompleted> CompetencyCompleted { get; set; }
        public ICollection<CompetencyLevelTrainings> CompetencyLevelTrainings { get; set; }
    }
}

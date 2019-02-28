using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class CompetencyLevelTrainings
    {
        public int Id { get; set; }
        public int CompetencyLevelId { get; set; }
        public int? TrainingId { get; set; }
        public int? TaskId { get; set; }

        public CompetencyLevels CompetencyLevel { get; set; }
    }
}

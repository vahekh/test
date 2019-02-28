using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class TrainingLanguageVersions
    {
        public int Id { get; set; }
        public int TrainingId { get; set; }
        public int LanguageId { get; set; }
        public int Version { get; set; }
        public int Status { get; set; }
        public bool IsProductionReady { get; set; }
        public bool IsHtml5 { get; set; }
        public bool AutoAdvance { get; set; }
        public DateTime LastChangeDate { get; set; }
        public bool Deleted { get; set; }

        public Languages Language { get; set; }
        public Trainings Training { get; set; }
    }
}

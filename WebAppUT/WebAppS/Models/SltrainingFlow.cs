using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SltrainingFlow
    {
        public int Id { get; set; }
        public int Seq { get; set; }
        public int? Chapter { get; set; }
        public int? PageId { get; set; }
        public int? QuizId { get; set; }
        public bool IsAllowedClickThrough { get; set; }
        public int FlowWait { get; set; }
        public int LanguageId { get; set; }
        public int Version { get; set; }
        public int? ModuleId { get; set; }

        public Slpages Page { get; set; }
        public Slquizzes Quiz { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SurveyDocuments
    {
        public int Id { get; set; }
        public int SurveyId { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public bool? Marked { get; set; }
        public int? Fid { get; set; }

        public Surveys Survey { get; set; }
    }
}

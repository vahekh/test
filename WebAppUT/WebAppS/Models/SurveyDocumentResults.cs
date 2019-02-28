using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SurveyDocumentResults
    {
        public int Id { get; set; }
        public int? SurveyAnswerId { get; set; }
        public int SurveyDocumentId { get; set; }
        public string FileName { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public int? Fid { get; set; }

        public SurveyAnswers SurveyAnswer { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SurveyPredefinedAnswers
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int? RowId { get; set; }
        public int? ColumnId { get; set; }
        public string Text { get; set; }
        public string AttachementName { get; set; }
        public int? Fid { get; set; }

        public SurveyQuestions Question { get; set; }
    }
}

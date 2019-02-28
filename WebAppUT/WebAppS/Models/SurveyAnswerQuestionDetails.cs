using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SurveyAnswerQuestionDetails
    {
        public int Id { get; set; }
        public int AnswerQuestionId { get; set; }
        public int? RowId { get; set; }
        public int? ColumnId { get; set; }
        public string Text { get; set; }
        public int? Rate { get; set; }
        public int? PredefinedAnswerId { get; set; }
        public int? SdssheetId { get; set; }
        public int GroupId { get; set; }
        public int? Fid { get; set; }

        public SurveyAnswerQuestions AnswerQuestion { get; set; }
    }
}

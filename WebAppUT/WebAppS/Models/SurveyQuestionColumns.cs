using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SurveyQuestionColumns
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Text { get; set; }
        public int? Fid { get; set; }
        public int? AnswerId { get; set; }

        public SurveyAnswers Answer { get; set; }
        public SurveyQuestions Question { get; set; }
    }
}

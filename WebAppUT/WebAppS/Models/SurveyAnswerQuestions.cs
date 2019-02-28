using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SurveyAnswerQuestions
    {
        public SurveyAnswerQuestions()
        {
            SurveyAnswerQuestionDetails = new HashSet<SurveyAnswerQuestionDetails>();
        }

        public int Id { get; set; }
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public string OptionalAnswer { get; set; }
        public string FileName { get; set; }
        public int? Fid { get; set; }
        public string Notes { get; set; }

        public SurveyAnswers Answer { get; set; }
        public SurveyQuestions Question { get; set; }
        public ICollection<SurveyAnswerQuestionDetails> SurveyAnswerQuestionDetails { get; set; }
    }
}

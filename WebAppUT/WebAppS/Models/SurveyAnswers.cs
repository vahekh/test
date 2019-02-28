using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SurveyAnswers
    {
        public SurveyAnswers()
        {
            SurveyAnswerQuestions = new HashSet<SurveyAnswerQuestions>();
            SurveyDocumentResults = new HashSet<SurveyDocumentResults>();
            SurveyQuestionColumns = new HashSet<SurveyQuestionColumns>();
            SurveyQuestionRows = new HashSet<SurveyQuestionRows>();
        }

        public int Id { get; set; }
        public int SurveyId { get; set; }
        public int? TrainingId { get; set; }
        public int? RunLogId { get; set; }
        public int? FilledByClientId { get; set; }
        public int? FilledByUserId { get; set; }
        public DateTimeOffset FilledDate { get; set; }
        public bool? IsFinished { get; set; }
        public int? SurveyClientId { get; set; }
        public int? Status { get; set; }
        public bool? CopyToDocuments { get; set; }
        public int? LocationId { get; set; }
        public string Location { get; set; }
        public int? Fid { get; set; }

        public Surveys Survey { get; set; }
        public ICollection<SurveyAnswerQuestions> SurveyAnswerQuestions { get; set; }
        public ICollection<SurveyDocumentResults> SurveyDocumentResults { get; set; }
        public ICollection<SurveyQuestionColumns> SurveyQuestionColumns { get; set; }
        public ICollection<SurveyQuestionRows> SurveyQuestionRows { get; set; }
    }
}

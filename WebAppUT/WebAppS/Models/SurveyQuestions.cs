using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SurveyQuestions
    {
        public SurveyQuestions()
        {
            SurveyAnswerQuestions = new HashSet<SurveyAnswerQuestions>();
            SurveyPredefinedAnswers = new HashSet<SurveyPredefinedAnswers>();
            SurveyQuestionColumns = new HashSet<SurveyQuestionColumns>();
            SurveyQuestionRates = new HashSet<SurveyQuestionRates>();
            SurveyQuestionRows = new HashSet<SurveyQuestionRows>();
        }

        public int Id { get; set; }
        public int SurveyId { get; set; }
        public int QuestionType { get; set; }
        public string Text { get; set; }
        public string OtherOptionLabel { get; set; }
        public int Sequence { get; set; }
        public bool IsRequired { get; set; }
        public bool IsDeleted { get; set; }
        public string MergeField { get; set; }
        public string Description { get; set; }
        public bool HasAttachment { get; set; }
        public int? Fid { get; set; }
        public bool ExcludeAnswer { get; set; }
        public bool InContent { get; set; }
        public string FixedTableHeader { get; set; }
        public int? RelatedQuestionId { get; set; }
        public int? RelatedRowId { get; set; }
        public bool IsHidden { get; set; }

        public Surveys Survey { get; set; }
        public ICollection<SurveyAnswerQuestions> SurveyAnswerQuestions { get; set; }
        public ICollection<SurveyPredefinedAnswers> SurveyPredefinedAnswers { get; set; }
        public ICollection<SurveyQuestionColumns> SurveyQuestionColumns { get; set; }
        public ICollection<SurveyQuestionRates> SurveyQuestionRates { get; set; }
        public ICollection<SurveyQuestionRows> SurveyQuestionRows { get; set; }
    }
}

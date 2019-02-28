using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SurveyQuestionRates
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int StepFrom { get; set; }
        public int StepTo { get; set; }
        public string BeforeText { get; set; }
        public string AfterText { get; set; }

        public SurveyQuestions Question { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class AssignmentAnswers
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int AssignmentId { get; set; }
        public int QuestionId { get; set; }
        public bool? AnswerBool { get; set; }
        public string AnswerText { get; set; }
        public int? CompletedId { get; set; }
    }
}

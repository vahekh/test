using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SlconfigurationForLanguages
    {
        public int Id { get; set; }
        public int Version { get; set; }
        public int Revision { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime DateOfLastEdit { get; set; }
        public string Comments { get; set; }
        public int LanguageId { get; set; }
        public int IntroVideo { get; set; }
        public int CorrectAnswerSound { get; set; }
        public int WrongAnswerSound { get; set; }
        public int QuizPassSound { get; set; }
        public int QuizFailSound { get; set; }
        public bool? QuizIsRandomized { get; set; }
        public int? ModuleId { get; set; }
    }
}

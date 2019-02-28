using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Slanswers
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string AnswerXaml { get; set; }
        public bool IsRight { get; set; }
        public int? PictureId { get; set; }
        public int? ModuleId { get; set; }

        public Slquestions Question { get; set; }
    }
}

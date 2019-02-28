using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class RunLogQuiz
    {
        public RunLogQuiz()
        {
            QuizLog = new HashSet<QuizLog>();
        }

        public int Id { get; set; }
        public int RunLogId { get; set; }
        public int QuizId { get; set; }
        public double QuizPassingScore { get; set; }
        public DateTime QuizPassingDate { get; set; }
        public bool IsFinal { get; set; }
        public bool IsPass { get; set; }

        public RunLog RunLog { get; set; }
        public ICollection<QuizLog> QuizLog { get; set; }
    }
}

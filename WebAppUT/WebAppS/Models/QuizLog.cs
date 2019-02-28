using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class QuizLog
    {
        public int Id { get; set; }
        public int RunLogQuizId { get; set; }
        public int QuestionId { get; set; }
        public string Answers { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public bool IsAnswerRight { get; set; }
        public string Question { get; set; }
        public int TrainingId { get; set; }
        public int Count { get; set; }
        public string CorrectAnswer { get; set; }
        public int Chapter { get; set; }

        public SystemClients Client { get; set; }
        public RunLogQuiz RunLogQuiz { get; set; }
    }
}

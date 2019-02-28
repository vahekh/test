using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class RunLog
    {
        public RunLog()
        {
            RunLogQuiz = new HashSet<RunLogQuiz>();
            TrainingsCompleted = new HashSet<TrainingsCompleted>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public int TrainingId { get; set; }
        public int FlowId { get; set; }
        public string Ipv4 { get; set; }
        public string Computer { get; set; }
        public DateTime LastRequestDate { get; set; }
        public string BrowserType { get; set; }
        public string ComputerUser { get; set; }
        public int? ContinuationNumber { get; set; }
        public int? TrainingType { get; set; }
        public int Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? SpendTime { get; set; }

        public SystemClients Client { get; set; }
        public ICollection<RunLogQuiz> RunLogQuiz { get; set; }
        public ICollection<TrainingsCompleted> TrainingsCompleted { get; set; }
    }
}

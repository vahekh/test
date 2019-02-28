using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class GroupTrainingEmployees
    {
        public int Id { get; set; }
        public int GroupTrainingId { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public int MissedAnswerCount { get; set; }

        public SystemClients Client { get; set; }
        public Employees Employee { get; set; }
        public GroupTrainings GroupTraining { get; set; }
    }
}

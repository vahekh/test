using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class AssignmentQuestions
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int AssignmentId { get; set; }
        public int QuestionTypeId { get; set; }
        public string QuestionText { get; set; }
        public bool IsRequired { get; set; }

        public ClientAssignments Assignment { get; set; }
        public SystemClients Client { get; set; }
    }
}

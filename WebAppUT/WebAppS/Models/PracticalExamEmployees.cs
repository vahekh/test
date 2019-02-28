using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class PracticalExamEmployees
    {
        public int Id { get; set; }
        public int PracticalExamId { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public int AssignType { get; set; }
        public DateTime ClassRoomDate { get; set; }

        public PracticalExam PracticalExam { get; set; }
    }
}

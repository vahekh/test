using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class PracticalExam
    {
        public PracticalExam()
        {
            PracticalExamEmployees = new HashSet<PracticalExamEmployees>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int TrainingId { get; set; }
        public int VersionId { get; set; }
        public string EvaluatorName { get; set; }
        public string EvaluatorPhone { get; set; }
        public DateTime RecordCreatedDate { get; set; }
        public DateTime Date { get; set; }
        public int RecordCreatedByClientId { get; set; }
        public int RecordCreatedByEmployeeId { get; set; }
        public int? CourseType { get; set; }

        public ICollection<PracticalExamEmployees> PracticalExamEmployees { get; set; }
    }
}

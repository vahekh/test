using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class GroupTrainings
    {
        public GroupTrainings()
        {
            GroupTrainingEmployees = new HashSet<GroupTrainingEmployees>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int TrainingId { get; set; }
        public DateTime Date { get; set; }
        public string EvaluatorName { get; set; }
        public string EvaluatorPhone { get; set; }
        public DateTime RecordCreatedDate { get; set; }
        public int RecordCreatedByEmployeeId { get; set; }
        public bool IsTestedRequiredOnly { get; set; }
        public int VersionId { get; set; }
        public int LanguageId { get; set; }
        public string NoUsers { get; set; }
        public int? RecordCreatedByClientId { get; set; }
        public int? CourseType { get; set; }
        public DateTime? ImportDate { get; set; }

        public SystemClients Client { get; set; }
        public ICollection<GroupTrainingEmployees> GroupTrainingEmployees { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class TrainingsCompleted
    {
        public TrainingsCompleted()
        {
            ExternalLms = new HashSet<ExternalLms>();
            UserCertificates = new HashSet<UserCertificates>();
        }

        public int Id { get; set; }
        public int TrainingId { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public double? TrainingScore { get; set; }
        public DateTime TrainingStartDate { get; set; }
        public DateTime? TrainingFinishDate { get; set; }
        public int? GroupTrainingId { get; set; }
        public int? RunLogId { get; set; }
        public bool? IsExempt { get; set; }
        public int? LanguageId { get; set; }
        public int Version { get; set; }
        public DateTime? VersionDateofLastChange { get; set; }
        public DateTime? TrainingFinishDateForClassroom { get; set; }
        public bool? Expired { get; set; }
        public int? CompletedMethod { get; set; }
        public string AgreeFirstName { get; set; }
        public string AgreeLastName { get; set; }
        public bool IsAgree { get; set; }
        public int? Cehours { get; set; }
        public int? PracticalExamId { get; set; }
        public int Status { get; set; }
        public DateTime? ExpireDate { get; set; }
        public int? TrainingVersionLanguageId { get; set; }
        public string BlobName { get; set; }
        public double? Duration { get; set; }
        public double? CehourF { get; set; }

        public SystemClients Client { get; set; }
        public Employees Employee { get; set; }
        public RunLog RunLog { get; set; }
        public ICollection<ExternalLms> ExternalLms { get; set; }
        public ICollection<UserCertificates> UserCertificates { get; set; }
    }
}

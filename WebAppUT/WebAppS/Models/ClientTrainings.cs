using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ClientTrainings
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int TrainingId { get; set; }
        public string TrainingName { get; set; }
        public bool? IsPracticalExamRequired { get; set; }
        public int? OwnerOfTraining { get; set; }
        public int? Version { get; set; }
        public int? PurchasedLicenses { get; set; }
        public int? AvailableLicenses { get; set; }
        public int? SubjectId { get; set; }
        public string EmailOnFinish { get; set; }
        public int? EmployeeId { get; set; }
        public int? CompletionTime { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string ShowBefore { get; set; }
        public string ShowAfter { get; set; }
        public int? CustomMonthsUntilExpire { get; set; }
        public bool? Expired { get; set; }
        public bool IsManuallyAssigned { get; set; }
        public int? SyllabusId { get; set; }
        public int? PriorToExperation { get; set; }
        public int? TableOfContent { get; set; }
        public string CreditHours { get; set; }
        public string PassingScore { get; set; }
        public bool? IsMenuLeft { get; set; }
        public int? TrainingOrder { get; set; }
        public int Navigation { get; set; }
        public string Description { get; set; }
        public string RegistrationLink { get; set; }
        public int? DeliveryMethodId { get; set; }
        public decimal? Cost { get; set; }
        public int ScoreType { get; set; }
        public bool IsSignedDocumentRequired { get; set; }
        public string SignedDocumentName { get; set; }
        public string SignedDocumentBlobName { get; set; }
        public DateTimeOffset? ExemptBeforeDate { get; set; }
        public DateTimeOffset? ExemptAfterDate { get; set; }
        public double? CehoursF { get; set; }

        public Subject Subject { get; set; }
    }
}

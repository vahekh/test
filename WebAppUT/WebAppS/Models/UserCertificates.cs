using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class UserCertificates
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string BlobName { get; set; }
        public string CertificateId { get; set; }
        public int TrainingCompletedId { get; set; }
        public int CertificateFormId { get; set; }
        public string Pin { get; set; }

        public SystemClients Client { get; set; }
        public TrainingsCompleted TrainingCompleted { get; set; }
        public Employees User { get; set; }
    }
}

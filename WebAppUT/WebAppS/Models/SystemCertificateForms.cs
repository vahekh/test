using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SystemCertificateForms
    {
        public SystemCertificateForms()
        {
            SystemCertificateTrainings = new HashSet<SystemCertificateTrainings>();
        }

        public int Id { get; set; }
        public string FormContent { get; set; }
        public int? TrainingId { get; set; }
        public string Name { get; set; }
        public string SystemCode { get; set; }
        public bool IsDefault { get; set; }
        public int FormVersion { get; set; }
        public DateTime DateOfLastEdit { get; set; }
        public byte[] FormContentRpt { get; set; }
        public int ContentType { get; set; }
        public string BlobName { get; set; }

        public ICollection<SystemCertificateTrainings> SystemCertificateTrainings { get; set; }
    }
}

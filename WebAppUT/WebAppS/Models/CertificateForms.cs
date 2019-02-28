using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class CertificateForms
    {
        public CertificateForms()
        {
            CertificateTrainings = new HashSet<CertificateTrainings>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public string FormContent { get; set; }
        public int? TrainingId { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public int Version { get; set; }
        public DateTime DateOfLastEdit { get; set; }
        public byte[] FormContentRpt { get; set; }
        public int ContentType { get; set; }
        public string BlobName { get; set; }

        public ICollection<CertificateTrainings> CertificateTrainings { get; set; }
    }
}

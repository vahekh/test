using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class CertificateTrainings
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int CertificateFormId { get; set; }
        public int? TrainingId { get; set; }
        public int SetType { get; set; }

        public CertificateForms CertificateForm { get; set; }
    }
}

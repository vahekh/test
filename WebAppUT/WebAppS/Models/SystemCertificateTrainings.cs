using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SystemCertificateTrainings
    {
        public int Id { get; set; }
        public int CertificateFormId { get; set; }
        public int? TrainingId { get; set; }

        public SystemCertificateForms CertificateForm { get; set; }
    }
}

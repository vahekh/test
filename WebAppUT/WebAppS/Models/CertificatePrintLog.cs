using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class CertificatePrintLog
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? Date { get; set; }
        public int CertificateFormId { get; set; }
        public int TrainingCompletedId { get; set; }
        public int CertificateFormTypeId { get; set; }
        public string VerifyId { get; set; }
        public string VerifyFirstName { get; set; }
        public string VerifyLastName { get; set; }
        public int ClientId { get; set; }
    }
}

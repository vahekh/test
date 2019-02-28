using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class LicenseLog
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public int VendorClientId { get; set; }
        public byte[] Pdf { get; set; }
        public int? LicenseId { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Pin { get; set; }
        public string Name { get; set; }
        public int LicenseLevel { get; set; }
        public int ClientId { get; set; }
        public string BlobName { get; set; }
    }
}

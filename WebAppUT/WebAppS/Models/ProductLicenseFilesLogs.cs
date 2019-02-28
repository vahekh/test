using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ProductLicenseFilesLogs
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ContactPersonId { get; set; }
        public DateTimeOffset AcceptDate { get; set; }
        public int ProductId { get; set; }
        public int LicenseId { get; set; }
        public byte[] LicenseFile { get; set; }
        public int UserId { get; set; }
    }
}

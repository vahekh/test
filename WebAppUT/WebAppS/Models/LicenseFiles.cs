using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class LicenseFiles
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int LicenseLevel { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public byte[] FileData { get; set; }
        public string BlobName { get; set; }

        public SystemClients Client { get; set; }
    }
}

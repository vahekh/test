using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SystemMedia
    {
        public int Id { get; set; }
        public int DataType { get; set; }
        public byte[] Media { get; set; }
        public bool IsDefault { get; set; }
        public string BlobName { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ClientMedias
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int MediaType { get; set; }
        public string Name { get; set; }
        public byte[] Media { get; set; }
        public bool IsCurrent { get; set; }
        public string BlobName { get; set; }
    }
}

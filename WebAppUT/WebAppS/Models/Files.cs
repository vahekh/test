using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Files
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public byte[] Data { get; set; }
        public int? AssignmentId { get; set; }
        public int? CompletedId { get; set; }
        public int ClientId { get; set; }
        public string BlobName { get; set; }

        public SystemClients Client { get; set; }
    }
}

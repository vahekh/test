using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class GroupTrainingFiles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public byte[] Data { get; set; }
        public int GroupTrainingId { get; set; }
        public string BlobName { get; set; }
    }
}

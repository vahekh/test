using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Slmedia
    {
        public Slmedia()
        {
            Slquestions = new HashSet<Slquestions>();
        }

        public int Id { get; set; }
        public int Type { get; set; }
        public byte[] Media { get; set; }
        public int? LowQualityId { get; set; }
        public int? ModuleId { get; set; }
        public string Guid { get; set; }
        public string BlobName { get; set; }

        public ICollection<Slquestions> Slquestions { get; set; }
    }
}

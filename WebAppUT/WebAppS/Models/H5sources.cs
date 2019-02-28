using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class H5sources
    {
        public H5sources()
        {
            H5answers = new HashSet<H5answers>();
            H5pages = new HashSet<H5pages>();
            H5questions = new HashSet<H5questions>();
        }

        public int Id { get; set; }
        public string Guid { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public byte[] Data { get; set; }
        public int Status { get; set; }
        public int? ModuleId { get; set; }

        public ICollection<H5answers> H5answers { get; set; }
        public ICollection<H5pages> H5pages { get; set; }
        public ICollection<H5questions> H5questions { get; set; }
    }
}

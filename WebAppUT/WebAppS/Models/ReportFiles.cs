using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ReportFiles
    {
        public int Id { get; set; }
        public bool IsDefault { get; set; }
        public string Name { get; set; }
        public byte[] Report { get; set; }
    }
}

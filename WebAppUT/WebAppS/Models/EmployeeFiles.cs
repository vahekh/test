using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class EmployeeFiles
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public string Type { get; set; }
        public string BlobName { get; set; }
        public bool Shared { get; set; }

        public Employees Employee { get; set; }
    }
}

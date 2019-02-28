using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class EmployeeImages
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public string ImageName { get; set; }
        public int ImageType { get; set; }
        public byte[] ImageFile { get; set; }
        public string BlobName { get; set; }
    }
}

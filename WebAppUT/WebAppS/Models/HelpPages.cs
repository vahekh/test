using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class HelpPages
    {
        public HelpPages()
        {
            ProfileHelpPages = new HashSet<ProfileHelpPages>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public bool IsActive { get; set; }
        public int UploadedEmployeeId { get; set; }
        public DateTime UploadedDate { get; set; }
        public string FileType { get; set; }
        public int FolderId { get; set; }
        public int ClientId { get; set; }
        public string BlobName { get; set; }

        public ICollection<ProfileHelpPages> ProfileHelpPages { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Documents
    {
        public Documents()
        {
            ClientTrainingFiles = new HashSet<ClientTrainingFiles>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int FolderId { get; set; }
        public string Name { get; set; }
        public string FileType { get; set; }
        public byte[] Data { get; set; }
        public bool IsActive { get; set; }
        public int UploadedEmployeeId { get; set; }
        public DateTime UploadedDate { get; set; }
        public int? FactSheetReportId { get; set; }
        public int SourceType { get; set; }
        public int? SourceId { get; set; }
        public string BlobName { get; set; }

        public SystemClients Client { get; set; }
        public Folders Folder { get; set; }
        public ICollection<ClientTrainingFiles> ClientTrainingFiles { get; set; }
    }
}

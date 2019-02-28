using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Reports
    {
        public Reports()
        {
            ReportClients = new HashSet<ReportClients>();
            ReportParams = new HashSet<ReportParams>();
        }

        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public string Layout { get; set; }
        public byte[] DesignFile { get; set; }
        public bool Landscape { get; set; }
        public bool IsPrivate { get; set; }
        public string BlobName { get; set; }
        public string Spname { get; set; }
        public string LayoutNew { get; set; }

        public SystemClients Client { get; set; }
        public ICollection<ReportClients> ReportClients { get; set; }
        public ICollection<ReportParams> ReportParams { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class H5links
    {
        public int Id { get; set; }
        public int FlowId { get; set; }
        public decimal TopPosition { get; set; }
        public decimal LeftPosition { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public int? HrefFlowId { get; set; }
        public string ExternalUrl { get; set; }
        public int? LinkType { get; set; }
        public int? ModuleId { get; set; }

        public H5flow Flow { get; set; }
    }
}

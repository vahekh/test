using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class WhiteLabelLinks
    {
        public int Id { get; set; }
        public int WhiteLabelId { get; set; }
        public int WhitelabelHostId { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Value { get; set; }

        public WhiteLabels WhiteLabel { get; set; }
        public WhiteLabelHosts WhitelabelHost { get; set; }
    }
}

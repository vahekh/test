using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class FoundInfos
    {
        public int Id { get; set; }
        public int WhiteLabelId { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public bool IsActive { get; set; }

        public WhiteLabels WhiteLabel { get; set; }
    }
}

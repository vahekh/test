using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class CommissionGroupAssignments
    {
        public int Id { get; set; }
        public int WhiteLabelId { get; set; }
        public int SalesPersonGroupId { get; set; }
        public int ProductGroupId { get; set; }
        public int CommissionGroupId { get; set; }

        public WhiteLabels WhiteLabel { get; set; }
    }
}

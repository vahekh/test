using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class CommissionGroups
    {
        public CommissionGroups()
        {
            CommissionScheduleGroups = new HashSet<CommissionScheduleGroups>();
            Products = new HashSet<Products>();
            SalesPersonGroups = new HashSet<SalesPersonGroups>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int WhiteLabelId { get; set; }
        public int IndustryId { get; set; }
        public bool? IsActive { get; set; }
        public int? TypeId { get; set; }

        public Industries Industry { get; set; }
        public WhiteLabels WhiteLabel { get; set; }
        public ICollection<CommissionScheduleGroups> CommissionScheduleGroups { get; set; }
        public ICollection<Products> Products { get; set; }
        public ICollection<SalesPersonGroups> SalesPersonGroups { get; set; }
    }
}

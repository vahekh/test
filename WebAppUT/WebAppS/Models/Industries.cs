using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Industries
    {
        public Industries()
        {
            CommissionGroups = new HashSet<CommissionGroups>();
            ProductIndustries = new HashSet<ProductIndustries>();
            SalesPersons = new HashSet<SalesPersons>();
            WalkThroughAssigns = new HashSet<WalkThroughAssigns>();
        }

        public int Id { get; set; }
        public int WhiteLabelId { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
        public int? TemplateClientId { get; set; }
        public bool? IsActive { get; set; }

        public WhiteLabels WhiteLabel { get; set; }
        public ICollection<CommissionGroups> CommissionGroups { get; set; }
        public ICollection<ProductIndustries> ProductIndustries { get; set; }
        public ICollection<SalesPersons> SalesPersons { get; set; }
        public ICollection<WalkThroughAssigns> WalkThroughAssigns { get; set; }
    }
}

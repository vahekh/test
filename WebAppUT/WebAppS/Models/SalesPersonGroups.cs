using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SalesPersonGroups
    {
        public int Id { get; set; }
        public int SalesPersonId { get; set; }
        public int CommissionGroupId { get; set; }

        public CommissionGroups CommissionGroup { get; set; }
        public SalesPersons SalesPerson { get; set; }
    }
}

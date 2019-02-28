using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class EmailDistributionUsers
    {
        public int Id { get; set; }
        public int EmailDistributionListId { get; set; }
        public int UserId { get; set; }

        public EmailDistributionList EmailDistributionList { get; set; }
        public Employees User { get; set; }
    }
}

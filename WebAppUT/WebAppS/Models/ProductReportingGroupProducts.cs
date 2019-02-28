using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ProductReportingGroupProducts
    {
        public int Id { get; set; }
        public int ProductReportingGroupId { get; set; }
        public int ProductId { get; set; }
    }
}

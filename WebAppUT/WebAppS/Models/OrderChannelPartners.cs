using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class OrderChannelPartners
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int SalesPersonId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class OrderProductSets
    {
        public int Id { get; set; }
        public int OrderProductId { get; set; }
        public int SetId { get; set; }

        public OrderProducts OrderProduct { get; set; }
    }
}

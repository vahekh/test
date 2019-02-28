using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class DiscountTypes
    {
        public DiscountTypes()
        {
            Discounts = new HashSet<Discounts>();
        }

        public int Id { get; set; }
        public string Question1 { get; set; }
        public string Question2 { get; set; }

        public ICollection<Discounts> Discounts { get; set; }
    }
}

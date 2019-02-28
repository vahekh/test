using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ProductTrainings
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int TrainingId { get; set; }
        public int LicenseCount { get; set; }
        public bool ExpireUponRenew { get; set; }

        public Products Product { get; set; }
    }
}

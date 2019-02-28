using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class CustomFields
    {
        public int Id { get; set; }
        public int WhiteLabelId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public bool IsRequired { get; set; }
        public string DefaultValue { get; set; }

        public WhiteLabels WhiteLabel { get; set; }
    }
}

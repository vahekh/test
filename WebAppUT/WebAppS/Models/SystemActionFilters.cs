using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SystemActionFilters
    {
        public int Id { get; set; }
        public int FilterType { get; set; }
        public int TemplateDefaultId { get; set; }
        public int? Value { get; set; }
    }
}

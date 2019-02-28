using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ActionFilter
    {
        public int Id { get; set; }
        public int TemplateDefaultId { get; set; }
        public int? Value { get; set; }

        public EmailTemplateTypes TemplateDefault { get; set; }
    }
}

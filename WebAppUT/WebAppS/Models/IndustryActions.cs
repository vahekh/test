using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class IndustryActions
    {
        public int Id { get; set; }
        public int IndustryId { get; set; }
        public int ActionId { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsTextMessage { get; set; }
        public bool IsInternal { get; set; }
    }
}

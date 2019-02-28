using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SystemActionWffilters
    {
        public int Id { get; set; }
        public int FilterType { get; set; }
        public int ActionWfid { get; set; }
        public int Value { get; set; }

        public SystemActionWfs ActionWf { get; set; }
    }
}

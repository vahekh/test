using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SystemActionTypes
    {
        public SystemActionTypes()
        {
            SystemActions = new HashSet<SystemActions>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAutomatic { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsSystem { get; set; }
        public int? SystemCode { get; set; }

        public ICollection<SystemActions> SystemActions { get; set; }
    }
}

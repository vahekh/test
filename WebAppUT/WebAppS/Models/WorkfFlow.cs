using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class WorkfFlow
    {
        public WorkfFlow()
        {
            SystemActionWfs = new HashSet<SystemActionWfs>();
            Wfsteps = new HashSet<Wfsteps>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public int ClientId { get; set; }

        public ICollection<SystemActionWfs> SystemActionWfs { get; set; }
        public ICollection<Wfsteps> Wfsteps { get; set; }
    }
}

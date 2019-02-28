using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SetTops
    {
        public SetTops()
        {
            SetTopProfiles = new HashSet<SetTopProfiles>();
            Sets = new HashSet<Sets>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int? SystemCode { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }

        public ICollection<SetTopProfiles> SetTopProfiles { get; set; }
        public ICollection<Sets> Sets { get; set; }
    }
}

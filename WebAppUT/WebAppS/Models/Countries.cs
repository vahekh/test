using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Countries
    {
        public Countries()
        {
            States = new HashSet<States>();
            UserAddresses = new HashSet<UserAddresses>();
        }

        public string Abbreviation { get; set; }
        public string Name { get; set; }

        public ICollection<States> States { get; set; }
        public ICollection<UserAddresses> UserAddresses { get; set; }
    }
}

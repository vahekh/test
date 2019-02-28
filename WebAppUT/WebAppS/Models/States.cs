using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class States
    {
        public int Id { get; set; }
        public string CountryId { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }

        public Countries Country { get; set; }
    }
}

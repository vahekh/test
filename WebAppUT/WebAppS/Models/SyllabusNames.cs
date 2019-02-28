using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SyllabusNames
    {
        public SyllabusNames()
        {
            SyllabusAssignments = new HashSet<SyllabusAssignments>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ClientId { get; set; }

        public ICollection<SyllabusAssignments> SyllabusAssignments { get; set; }
    }
}

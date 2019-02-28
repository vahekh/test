using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SyllabusAssignments
    {
        public int Id { get; set; }
        public int SyllabusId { get; set; }
        public int AssignedId { get; set; }
        public int SetType { get; set; }

        public SyllabusNames Syllabus { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Slquizzes
    {
        public Slquizzes()
        {
            Slquestions = new HashSet<Slquestions>();
            SltrainingFlow = new HashSet<SltrainingFlow>();
        }

        public int Id { get; set; }
        public double PassingScore { get; set; }
        public int MinimumQuestions { get; set; }
        public bool IsFinal { get; set; }
        public bool IsOptional { get; set; }
        public int? ModuleId { get; set; }

        public ICollection<Slquestions> Slquestions { get; set; }
        public ICollection<SltrainingFlow> SltrainingFlow { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Cfrs
    {
        public int Id { get; set; }
        public int TrainingId { get; set; }
        public int? StateId { get; set; }
        public string Cfrnumber { get; set; }
        public int Cfrversion { get; set; }

        public Trainings Training { get; set; }
    }
}

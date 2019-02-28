using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Cehours
    {
        public int Id { get; set; }
        public int TrainingId { get; set; }
        public string State { get; set; }
        public int? Cehours1 { get; set; }
        public double? CehourF { get; set; }
    }
}

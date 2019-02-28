using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class H5quizzes
    {
        public H5quizzes()
        {
            H5flow = new HashSet<H5flow>();
            H5questions = new HashSet<H5questions>();
        }

        public int Id { get; set; }
        public int PassingScore { get; set; }
        public int? PassingTime { get; set; }
        public int MinimumQuestions { get; set; }
        public bool IsFinal { get; set; }
        public bool? HasBackground { get; set; }
        public bool IsOptional { get; set; }
        public int? ModuleId { get; set; }

        public ICollection<H5flow> H5flow { get; set; }
        public ICollection<H5questions> H5questions { get; set; }
    }
}

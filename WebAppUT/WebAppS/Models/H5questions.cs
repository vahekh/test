using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class H5questions
    {
        public H5questions()
        {
            H5answers = new HashSet<H5answers>();
        }

        public int Id { get; set; }
        public int QuizId { get; set; }
        public int Type { get; set; }
        public string HtmlText { get; set; }
        public int? PassingTime { get; set; }
        public TimeSpan? Duration { get; set; }
        public int? AudioId { get; set; }
        public int? PictureId { get; set; }
        public int? ModuleId { get; set; }

        public H5sources Audio { get; set; }
        public H5quizzes Quiz { get; set; }
        public ICollection<H5answers> H5answers { get; set; }
    }
}

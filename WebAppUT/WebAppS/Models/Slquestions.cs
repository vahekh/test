using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Slquestions
    {
        public Slquestions()
        {
            Slanswers = new HashSet<Slanswers>();
            SlquestionsRelated = new HashSet<SlquestionsRelated>();
        }

        public int Id { get; set; }
        public int QuizId { get; set; }
        public string Xaml { get; set; }
        public int QuestionTypeId { get; set; }
        public int? AudioId { get; set; }
        public TimeSpan? Duration { get; set; }
        public int? PictureId { get; set; }
        public int? ModuleId { get; set; }

        public Slmedia Audio { get; set; }
        public Slquizzes Quiz { get; set; }
        public ICollection<Slanswers> Slanswers { get; set; }
        public ICollection<SlquestionsRelated> SlquestionsRelated { get; set; }
    }
}

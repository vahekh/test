using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class EventCourses
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int CourseId { get; set; }
        public int SetType { get; set; }
        public int ScoreType { get; set; }
        public string CreditHours { get; set; }

        public Events Event { get; set; }
    }
}

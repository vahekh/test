using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SlquestionsRelated
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int PageId { get; set; }
        public int? ModuleId { get; set; }

        public Slpages Page { get; set; }
        public Slquestions Question { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class H5answers
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string HtmlText { get; set; }
        public bool IsRight { get; set; }
        public int? PictureId { get; set; }
        public int? ModuleId { get; set; }

        public H5sources Picture { get; set; }
        public H5questions Question { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class H5surveys
    {
        public H5surveys()
        {
            H5flow = new HashSet<H5flow>();
        }

        public int Id { get; set; }
        public int SurveyId { get; set; }
        public string Title { get; set; }
        public bool IsRequired { get; set; }
        public int? ModuleId { get; set; }

        public ICollection<H5flow> H5flow { get; set; }
    }
}

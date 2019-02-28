using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Sldocuments
    {
        public int Id { get; set; }
        public int DocType { get; set; }
        public string DocName { get; set; }
        public DateTime DocDateOfLastEdit { get; set; }
        public string DocData { get; set; }
        public int? ModuleId { get; set; }
    }
}

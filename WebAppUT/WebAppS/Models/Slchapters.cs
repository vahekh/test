using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Slchapters
    {
        public int Id { get; set; }
        public int Chapter { get; set; }
        public string Title { get; set; }
        public int? ModuleId { get; set; }
    }
}

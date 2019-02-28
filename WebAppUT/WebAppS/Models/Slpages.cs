using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Slpages
    {
        public Slpages()
        {
            SlquestionsRelated = new HashSet<SlquestionsRelated>();
            SltrainingFlow = new HashSet<SltrainingFlow>();
        }

        public int Id { get; set; }
        public int PageNumber { get; set; }
        public string PageXaml { get; set; }
        public bool IsInteractive { get; set; }
        public byte[] PageDll { get; set; }
        public TimeSpan? Duration { get; set; }
        public string Title { get; set; }
        public int? ModuleId { get; set; }

        public ICollection<SlquestionsRelated> SlquestionsRelated { get; set; }
        public ICollection<SltrainingFlow> SltrainingFlow { get; set; }
    }
}

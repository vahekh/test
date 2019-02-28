using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class H5pages
    {
        public H5pages()
        {
            H5flow = new HashSet<H5flow>();
        }

        public int Id { get; set; }
        public int? Type { get; set; }
        public int? AudioId { get; set; }
        public int? SourceId { get; set; }
        public int? SourceAudioId { get; set; }
        public TimeSpan? Duration { get; set; }
        public string Title { get; set; }
        public string MimeType { get; set; }
        public int? SlideId { get; set; }
        public int? ModuleId { get; set; }
        public string Guid { get; set; }

        public H5sources Source { get; set; }
        public ICollection<H5flow> H5flow { get; set; }
    }
}

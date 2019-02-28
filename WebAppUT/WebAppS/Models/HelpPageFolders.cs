using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class HelpPageFolders
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public int ClientId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class StreportColumns
    {
        public int Id { get; set; }
        public int StreportId { get; set; }
        public string ColumnName { get; set; }
        public string FriendlyName { get; set; }
        public int Position { get; set; }
        public int? RelationalId { get; set; }

        public Streports Streport { get; set; }
    }
}

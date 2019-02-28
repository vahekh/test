using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Streports
    {
        public Streports()
        {
            StreportColumns = new HashSet<StreportColumns>();
        }

        public int Id { get; set; }
        public string TableName { get; set; }
        public string FriendlyName { get; set; }
        public bool IsActive { get; set; }
        public string Layout { get; set; }

        public ICollection<StreportColumns> StreportColumns { get; set; }
    }
}

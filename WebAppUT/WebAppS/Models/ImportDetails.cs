using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ImportDetails
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public int Type { get; set; }
        public int TypeId { get; set; }
        public DateTime DateLastSeen { get; set; }
    }
}

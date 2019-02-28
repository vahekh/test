using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ProfileReports
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ProfileId { get; set; }
        public int ReportId { get; set; }
        public int TypeId { get; set; }

        public Profiles Profile { get; set; }
    }
}

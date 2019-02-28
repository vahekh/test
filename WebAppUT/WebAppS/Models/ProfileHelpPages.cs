using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ProfileHelpPages
    {
        public int Id { get; set; }
        public int? ProfileId { get; set; }
        public int HelpPageId { get; set; }
        public int ClientId { get; set; }

        public HelpPages HelpPage { get; set; }
        public Profiles Profile { get; set; }
    }
}

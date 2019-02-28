using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SetTopProfiles
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public int SetTopId { get; set; }
        public bool? AllowAssign { get; set; }
        public bool? AllowModify { get; set; }
        public bool? AllowManageGroup { get; set; }
        public bool? AllowManageSelected { get; set; }

        public Profiles Profile { get; set; }
        public SetTops SetTop { get; set; }
    }
}

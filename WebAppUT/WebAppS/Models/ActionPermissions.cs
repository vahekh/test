using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ActionPermissions
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ActionId { get; set; }
        public int GroupType { get; set; }
        public int GroupTypeId { get; set; }
    }
}

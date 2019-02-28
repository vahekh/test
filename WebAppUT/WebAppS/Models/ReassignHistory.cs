using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ReassignHistory
    {
        public int Id { get; set; }
        public int AssignedId { get; set; }
        public int SetType { get; set; }
        public DateTime ProcessDate { get; set; }
        public int ClientId { get; set; }
        public int? UserId { get; set; }
    }
}

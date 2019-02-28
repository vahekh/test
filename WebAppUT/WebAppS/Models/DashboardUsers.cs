using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class DashboardUsers
    {
        public int Id { get; set; }
        public int DashboardId { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
    }
}

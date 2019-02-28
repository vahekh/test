using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ServiceLogs
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int ActionId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}

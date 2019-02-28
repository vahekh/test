using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ClientLogs
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string TableName { get; set; }
        public string TableKey { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string Notes { get; set; }
        public DateTime Date { get; set; }
        public string Ip { get; set; }
        public int EmployeeId { get; set; }
    }
}

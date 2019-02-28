using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SystemSettings
    {
        public int Id { get; set; }
        public int KeyType { get; set; }
        public string KeyName { get; set; }
        public string KeyValue { get; set; }
        public int? WhiteLabelId { get; set; }
    }
}

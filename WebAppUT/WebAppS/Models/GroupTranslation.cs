using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class GroupTranslation
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string GroupName { get; set; }
        public string MainGroupName { get; set; }
        public int? GroupId { get; set; }
        public DateTime? LastTranslationDate { get; set; }
        public int LastNumberOfTranslations { get; set; }

        public SystemClients Client { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class TextBases
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? LanguageId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

        public SystemClients Client { get; set; }
        public Languages Language { get; set; }
    }
}

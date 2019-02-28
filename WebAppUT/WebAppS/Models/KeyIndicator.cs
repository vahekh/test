using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class KeyIndicator
    {
        public KeyIndicator()
        {
            KeyIndicatorValues = new HashSet<KeyIndicatorValues>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<KeyIndicatorValues> KeyIndicatorValues { get; set; }
    }
}

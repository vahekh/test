using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class KeyIndicatorValues
    {
        public int Id { get; set; }
        public int KeyIndicatorId { get; set; }
        public int SalesPersonId { get; set; }
        public int Goal { get; set; }
        public int Actial { get; set; }
        public DateTimeOffset Date { get; set; }

        public KeyIndicator KeyIndicator { get; set; }
        public SalesPersons SalesPerson { get; set; }
    }
}

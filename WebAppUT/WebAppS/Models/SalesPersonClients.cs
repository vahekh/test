using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SalesPersonClients
    {
        public int Id { get; set; }
        public int SalesPersonId { get; set; }
        public int ClientId { get; set; }

        public SalesPersons SalesPerson { get; set; }
    }
}

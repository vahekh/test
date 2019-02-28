using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class TransactionTypes
    {
        public TransactionTypes()
        {
            Transactions = new HashSet<Transactions>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int DebitCredit { get; set; }

        public ICollection<Transactions> Transactions { get; set; }
    }
}

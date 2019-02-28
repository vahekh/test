using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SubscriptionPlans
    {
        public SubscriptionPlans()
        {
            Payments = new HashSet<Payments>();
            SystemClients = new HashSet<SystemClients>();
        }

        public int Id { get; set; }
        public int WhiteLabelId { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int NumberOfUsers { get; set; }
        public int AccessMonths { get; set; }
        public DateTimeOffset CreateDate { get; set; }

        public ICollection<Payments> Payments { get; set; }
        public ICollection<SystemClients> SystemClients { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class UserAddresses
    {
        public UserAddresses()
        {
            ClientPaymentMethods = new HashSet<ClientPaymentMethods>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CountryId { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsPrimary { get; set; }
        public DateTimeOffset CreateDate { get; set; }

        public SystemClients Client { get; set; }
        public Countries Country { get; set; }
        public Employees User { get; set; }
        public ICollection<ClientPaymentMethods> ClientPaymentMethods { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ContactPersonAddresses
    {
        public int Id { get; set; }
        public int ContactPersonId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsPrimary { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
    }
}

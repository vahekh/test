using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ContactInfos
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int? ProductId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public SystemClients Client { get; set; }
        public Products Product { get; set; }
    }
}

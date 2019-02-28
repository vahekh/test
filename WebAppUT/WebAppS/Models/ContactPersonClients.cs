using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ContactPersonClients
    {
        public int Id { get; set; }
        public int ContactPersonId { get; set; }
        public int ClientId { get; set; }
        public int? UserId { get; set; }

        public SystemClients Client { get; set; }
        public ContactPersons ContactPerson { get; set; }
    }
}

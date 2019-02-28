using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ContactPersons
    {
        public ContactPersons()
        {
            ContactPersonClients = new HashSet<ContactPersonClients>();
        }

        public int Id { get; set; }
        public int WhiteLabelId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public bool IsVerified { get; set; }
        public string Guid { get; set; }
        public DateTimeOffset? CreateDate { get; set; }
        public string CompanyName { get; set; }
        public string DoctorName { get; set; }
        public DateTimeOffset? LastLoginDate { get; set; }
        public string LoginToken { get; set; }
        public int? PgclientId { get; set; }
        public int? FoundInfoId { get; set; }
        public string FoundInfoOther { get; set; }
        public string AdditionalId { get; set; }
        public string SalesPersonOther { get; set; }

        public WhiteLabels WhiteLabel { get; set; }
        public ICollection<ContactPersonClients> ContactPersonClients { get; set; }
    }
}

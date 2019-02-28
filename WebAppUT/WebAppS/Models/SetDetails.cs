using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SetDetails
    {
        public int Id { get; set; }
        public int SetId { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string CountryId { get; set; }
        public DateTimeOffset CreatedDate { get; set; }

        public Sets Set { get; set; }
    }
}

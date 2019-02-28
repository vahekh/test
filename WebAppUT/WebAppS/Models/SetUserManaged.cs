using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SetUserManaged
    {
        public int Id { get; set; }
        public int SetId { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }

        public Sets Set { get; set; }
    }
}

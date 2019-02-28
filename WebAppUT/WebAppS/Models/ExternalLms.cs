using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ExternalLms
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public int TrainingsCompletedId { get; set; }
        public string Lmsid { get; set; }
        public string LmsreturnCode { get; set; }
        public string LmsreturnUrl { get; set; }
        public string Lmsother { get; set; }

        public SystemClients Client { get; set; }
        public Employees Employee { get; set; }
        public TrainingsCompleted TrainingsCompleted { get; set; }
    }
}

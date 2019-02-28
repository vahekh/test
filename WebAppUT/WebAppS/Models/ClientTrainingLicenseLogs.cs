using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ClientTrainingLicenseLogs
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ClientTrainingLicenseId { get; set; }
        public int? UserId { get; set; }
        public int TrainingId { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset ExpirationDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ClientTrainingLicenses
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ClientProductId { get; set; }
        public int TrainingId { get; set; }
        public int LicenseType { get; set; }
        public int? LicenseCount { get; set; }
        public int? RemainingLicenseCount { get; set; }

        public SystemClients Client { get; set; }
        public ClientProducts ClientProduct { get; set; }
    }
}

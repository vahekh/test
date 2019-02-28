using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ClientProducts
    {
        public ClientProducts()
        {
            ClientTrainingLicenses = new HashSet<ClientTrainingLicenses>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public int OrderProductId { get; set; }
        public DateTimeOffset ExpirationDate { get; set; }
        public bool? IsAgreementAccepted { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public int? FeatureId { get; set; }
        public int? PaymentId { get; set; }

        public SystemClients Client { get; set; }
        public OrderProducts OrderProduct { get; set; }
        public Payments Payment { get; set; }
        public Products Product { get; set; }
        public ICollection<ClientTrainingLicenses> ClientTrainingLicenses { get; set; }
    }
}
